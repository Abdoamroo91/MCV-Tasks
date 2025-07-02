interface tasksInterface
{
    List<Task> getAllTasks();
    void createTask(string taskName);
    void deleteTask(string taskName);
    void updateTask(string oldName, string newName);
}