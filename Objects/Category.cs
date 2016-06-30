using System.Collections.Generic;

namespace ToDoList.Objects
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Task> _tasks;

    public Category(string categoryName)
    {
      _name = categoryName;
      _instances.Add(this);
      _id = _instances.Count;
      _tasks = new List<Task>{}; //begins as empty list and will contain all the task objects in the Category instance
    }

    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Task> GetTasks()
    {
      return _tasks;
    }
    public void AddTask(Task task)
    {
      _tasks.Add(task); //AddTask accepts a task object and saves it to the _task list
    }
    public static List<Category> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Category Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
