using System.Collections.Generic;
using Domain;

namespace DAL;

// DAL - Data Access Layer - большое приложение разбивать на слои/модули

public interface IGameOptionsRepository
{
    // crud methods

    // read
    List<string> GetGameOptionsList();
    CheckersOptions GetGameOptions(string id);

    // create and update
    void SaveGameOptions(string id, CheckersOptions options);

    // delete
    void DeleteGameOptions(string id);
}