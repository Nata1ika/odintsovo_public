using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public class Apartament
    {
        public int      id;             //порядковый номер
        public int      number;         //настоящий номер
        public int      room;           //количество комнат
        public int      floor;          //этаж
        public int      section;        //секция
        public float    square;         //площадь
        public float    mprice;         //цена за кв. м.
        public int      price;          //цена
        public string   seller;         //продавец
        public string   house;          //корпус
        public bool     isSale;         //в продаже
        public bool     isFavorite = false;
        public int      groupFloor;     //группа этажей со схожими планировками
        public int      numberFloor;    //номер на лестничной площадке
    }
}
