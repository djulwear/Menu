using System;
using System.Collections.Generic;
using System.IO;
using Domain;
using DAL;

namespace DAL.FileSystem;

public class GameOptionsRepositoryFileSystem : IGameOptionsRepository
{
    private const string FileExtension = "json";
    private readonly string _optionsDirectory = "." + System.IO.Path.DirectorySeparatorChar + "options";

    public List<string> GetGameOptionsList()
    {
        CheckOrCreateDirectory();

        var res = new List<string>();

        foreach (var fileName in Directory.GetFileSystemEntries(_optionsDirectory, "*." + FileExtension))
        {
            res.Add(System.IO.Path.GetFileNameWithoutExtension(fileName));
        }

        return res;
    }

    // json serializer - данные из одного формата парсить в другой формат

    public CheckersOptions GetGameOptions(string id)
    {
        var fileContent = System.IO.File.ReadAllText(GetFileName(id));
        var options = System.Text.Json.JsonSerializer.Deserialize<CheckersOptions>(fileContent);
        if (options == null)
        {
            throw new NullReferenceException($"Could not deserialize: {fileContent}");
        }

        return options;
    }

    public void SaveGameOptions(string id, CheckersOptions options)
    {
        CheckOrCreateDirectory();

        var fileContent = System.Text.Json.JsonSerializer.Serialize(options);
        System.IO.File.WriteAllText(GetFileName(id), fileContent);
    }

    public void DeleteGameOptions(string id)
    {
        System.IO.File.Delete(GetFileName(id));
    }

    private string GetFileName(string id)
    {
        return _optionsDirectory +
               System.IO.Path.DirectorySeparatorChar +
               id + "." + FileExtension;
    }

    private void CheckOrCreateDirectory()
    {
        if (!System.IO.Directory.Exists(_optionsDirectory))
        {
            System.IO.Directory.CreateDirectory(_optionsDirectory);
        }
    }
}