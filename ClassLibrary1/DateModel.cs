using System;
using System.Collections.Generic;

namespace Request
{
    /// <summary>
    /// Заявка
    /// </summary>
    public class NewRequest
    {
        /// <summary>
        /// Месторасположене
        /// </summary>
        public List<Locations> Location { get; set; }
        /// <summary>
        /// Колличество комнат
        /// </summary>
        public string NumberRooms { get; set; }
        /// <summary>
        /// Удобства
        /// </summary>
        public Conveniences Conveniences { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public string Price { get; set; }
        public override string ToString()
        {
            return $"{nameof(Description)}: {Description}, {nameof(Price)}: {Price}, {nameof(NumberRooms)}: {NumberRooms}";
        }
    }

    /// <summary>
    /// Удобства
    /// </summary>
    public enum Conveniences
    {
        /// <summary>
        /// Фен
        /// </summary>
        Hairdryer,
        /// <summary>
        /// Утюг
        /// </summary>
        Iron,
        /// <summary>
        /// Микроволновка
        /// </summary>
        Microwave,
        /// <summary>
        /// Набо умывальных принадлежностей
        /// </summary>
        SetWash,
    }
    /// <summary>
    /// Месторасположение
    /// </summary>
    public enum Locations
    {
        /// <summary>
        ///Москва
        /// </summary>
        Moscow,
        /// <summary>
        /// Питер
        /// </summary>
        Petersburg,
        /// <summary>
        /// Казань
        /// </summary>
        Kazan,
    }
 }