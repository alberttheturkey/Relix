using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication4
{
    // Persistence class as per good coding practise
    public static class Persistence
    {
        /// <summary>
        /// Load our equipment list using serialization
        /// </summary>
        /// <param name="filename">Filename to load equipment list from</param>
        /// <returns>Object version of equipment list</returns>
        public static EquipmentList loadEquipmentList(String filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            EquipmentList result = (EquipmentList)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }
        
        /// <summary>
        /// Save our equipment list using serialization
        /// </summary>
        /// <param name="toSave">Equipment list to save</param>
        /// <param name="filename">Filename to save the equipment list to</param>
        public static void saveEquipmentList(EquipmentList toSave, String filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, toSave);
            stream.Close();
        }

        /// <summary>
        /// Load our Player Stats using serialization
        /// </summary>
        /// <param name="filename">Filename to use to load player stats</param>
        /// <returns>Object version of Playerstats</returns>
        public static PlayerStats loadPlayerStats(String filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename,
                                      FileMode.Open,
                                      FileAccess.Read,
                                      FileShare.Read);
            PlayerStats result = (PlayerStats)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }

        /// <summary>
        /// Save our Player Stats using serialization
        /// </summary>
        /// <param name="toSave">Playerstat object to save</param>
        /// <param name="filename">Filename to use to save the player stats</param>
        public static void savePlayerStats(PlayerStats toSave, String filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename,
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, toSave);
            stream.Close();
        }
    }
}
