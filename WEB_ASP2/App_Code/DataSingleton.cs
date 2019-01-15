using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataSingleton
/// </summary>
public class DataSingleton
{
    private static readonly DataSingleton instance = new DataSingleton();

    public static DataSingleton getInstance()
    {
        return instance;
    }

    public CartItem[][] CartItems { get; private set; }

    private DataSingleton()
    {
        CartItem[] js = { new CartItem("JavaScript od podstaw", 12.9), new CartItem("JavaScript dla każdego", 10.0), new CartItem("JavaScript - zostan programista w tydzien", 15.6) };
        CartItem[] py = { new CartItem("Uczenie maszynowe w Pythonie", 16), new CartItem("Moj pierwszy serwer w pythonie", 10), new CartItem("Wstep do programowania - Python", 16) };
        CartItem[] java = { new CartItem("Java od podstaw", 14.0), new CartItem("Spring - podstawy", 12.9), new CartItem("Programowanie dla kazdego - Java", 10) };
        CartItem[] cs = { new CartItem("C# od podstaw", 13.8), new CartItem("Wstęp do programowania obiektowego - C#", 20.8) };

        CartItem[][] tmp = { js, py, java, cs };

        CartItems = tmp;
    }
}