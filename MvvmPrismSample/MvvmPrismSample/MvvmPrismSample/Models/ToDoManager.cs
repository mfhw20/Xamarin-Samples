﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmPrismSample.Models
{
    public static class ToDoManager
    {
        private static List<ToDoItem> DefaultToDoList;

        static ToDoManager()
        {
            DefaultToDoList = new List<ToDoItem>
            {
                new ToDoItem
                {
                    Name = "Buy apple 2kg",
                    Note = "Shopping at Big C Thang Long",
                    Date = new DateTime(2017,10,25),
                    Time = new TimeSpan(18,30,00),
                    Done = false
                },
                new ToDoItem
                {
                    Name = "Buy pork 500g",
                    Note = "Shopping at Big C Thang Long",
                    Date = new DateTime(2017,10,25),
                    Time = new TimeSpan(18,30,00),
                    Done = false
                },
                new ToDoItem
                {
                    Name = "Buy egg half dozen",
                    Note = "Shopping at Big C Thang Long",
                    Date = new DateTime(2017,10,25),
                    Time = new TimeSpan(18,30,00),
                    Done = false
                },
                new ToDoItem
                {
                    Name = "Buy milk 500ml",
                    Note = "Shopping at Big C Thang Long",
                    Date = new DateTime(2017,10,25),
                    Time = new TimeSpan(18,30,00),
                    Done = false
                },
                new ToDoItem
                {
                    Name = "Buy oliver oil",
                    Note = "Shopping at Big C Thang Long",
                    Date = new DateTime(2017,10,25),
                    Time = new TimeSpan(18,30,00),
                    Done = false
                },
            };
        }

        public static ObservableCollection<ToDoItem> GetTodolist()
        {
            ObservableCollection<ToDoItem> todolist = new ObservableCollection<ToDoItem>();
            foreach (var item in DefaultToDoList)
            {
                todolist.Add(item);
            }

            return todolist;
        }

        public static void AddItemToTodolist(ToDoItem newItem)
        {
            DefaultToDoList.Add(newItem);
        }

        public static void UpdateItemToTodolist(ToDoItem editItem)
        {
            foreach (var item in DefaultToDoList)
            {
                if (item.Id == editItem.Id)
                {
                    DefaultToDoList.Remove(item);
                    DefaultToDoList.Add(editItem);
                }
            }
        }
    }
}
