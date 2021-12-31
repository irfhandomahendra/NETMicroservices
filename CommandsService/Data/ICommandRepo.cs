using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepo
    {
        bool SaveChanges();

        //platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform plat);
        bool PlatformExist(int platformid);

        //Command
        IEnumerable<Command> GetCommandsForPlatform(int platformid);
        Command GetCommand(int platformId,int commandId);
        void CreateCommand(int platformId, Command command);
    }
}