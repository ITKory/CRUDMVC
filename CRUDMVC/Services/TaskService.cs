using CRUDMVC.Models;

namespace CRUDMVC.Services
{
    public class TaskService
    {
        private ToDoContext _context;
        public TaskService(ToDoContext context)
        {
            _context = context;
        }


        public List<Taska> GetTasks() => _context.Taskas.ToList();
        public void AddTask(string text)
        {
            _context.Add(new Taska
            {
                Status = "In progress",
                Text = text,
            });
            _context.SaveChanges();
        }

        public void RemoveTask(int id)
        {
            _context.Remove(_context.Taskas.Where(t => t.Id == id).First());
            _context.SaveChanges();
        }
        public void UpdateTask(int id, string text, string status)
        {

            var task = _context.Taskas.Where(t => t.Id == id).First();
            task.Text = text;
            task.Status = status;
            task.Id = id;

            _context.Update(task);
            _context.SaveChanges();

        }


    }
}
