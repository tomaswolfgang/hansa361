﻿using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

    public static string CurrentArea { get; set; }
    //public static int[,] Edges = new int[10, 5] { { 2, 9, 0, 0 , 0 }, { 1, 4,0,0,0 }, { 4,0,0,0,0 }, { 2, 3 , 5 , 9 ,0 }, { 4, 6, 7, 8,0}, { 5, 7,0,0,0 }, { 5,6,0,0,0 }, { 5,10,0,0,0 }, { 1,4,10,0,0 }, { 8,9 ,0,0,0} };

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    
    public static BaseEquipment EquipmentOne { get; set;}

	public static string PlayerName { get; set;}
    public static int PlayerLevel { get; set;}
    public static BaseCharacterClass PlayerClass { get; set;}
    public static int Strength { get; set;}
    public static int Agility { get; set;}
    public static int Intellect { get; set;}
    public static int Defense { get; set;}
}
