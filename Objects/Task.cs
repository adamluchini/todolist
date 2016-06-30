using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Task
  {
    private string _description;
    private int _id;
    private static List<Task> _instances = new List<Task> {};

    public Task(string description)
    {
      _description = description;
      _instances.Add(this); //this is referencing the object Task and adding it to the static List _instances
      _id = _instances.Count; //setting the added Task's id to the number of items in _instances
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Task> GetAll()
    { //GetAll() to access the private field _instances
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Task Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
