using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgsqlAPI
{
    public static class Data
    {
        public static List<Model> Models;
        public static List<Equipment> Equipment;

        public static void RefreshModels()
        {
            Models = DatabaseHandler.GetModels();
        }
    }
    
    public struct Model
    {
        public int id;
        public string name;
    }

    public class Equipment
    {
        public string name;
        public int id;
        public int model;

        public Equipment(string name, int model)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.id = -1;
            this.model = model;
        }
    }

    public class History_Pos
    {
        int id;
        DateTime date;
        int latitude;
        int longitude;
    }

    public class  History_State
    {
        int id;
        DateTime date;
        int state;
    }
}
