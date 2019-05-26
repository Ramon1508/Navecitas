using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary; 
using System.IO;

public static class Globales
{
    public static int puntuacion = 0;
    public static bool locura = false;
    public static List<int> Puntuaciones;
    public static void Save() {
        Puntuaciones.Add(puntuacion);
        Puntuaciones.Sort((x, y) => y.CompareTo(x));
        int contador = Puntuaciones.Count;
        if (contador > 10) contador = 10;
        Puntuaciones = Puntuaciones.GetRange(0,contador);
        puntuacion = 0;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create (Application.persistentDataPath + "/savedGames.gd");
        bf.Serialize(file, Puntuaciones);
        file.Close();
    }
    public static void Load() {
        if(File.Exists(Application.persistentDataPath + "/savedGames.gd")) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            Puntuaciones = (List<int>)bf.Deserialize(file);
            file.Close();
        }
        else {
            Puntuaciones = new List<int>();
        }
    }
}
