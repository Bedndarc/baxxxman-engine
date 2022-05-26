using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SaveData
{
    public const string Gems = nameof(Gems);
    public const string Accelerate = nameof(Accelerate);
    public const string Sound = nameof(Sound);
    public const string Level = nameof(Level);

    public static bool Has(string key)
    {
        return PlayerPrefs.HasKey(key);
    }

    public static void Save(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
    }

    public static void Save(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public static int GetInt(string key)
    {
        return PlayerPrefs.GetInt(key);
    }

    public static string GetString(string key)
    {
        return PlayerPrefs.GetString(key);
    }
}
