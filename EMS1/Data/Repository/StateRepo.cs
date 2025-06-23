using EMS1.Data.Interface;
using EMS1.Models;

namespace EMS1.Data.Repository
{
    public class StateRepo : IState
    {
        private readonly AppDbContext _context;
        public StateRepo(AppDbContext context)
        {
            _context = context;
        }


        public List<State> GetAllStates()
        {
            return _context.States.ToList();
        }

        public string AddState(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
            return "State Added Successfully!";
        }

        public string UpdateState(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
            return "State Update Successfully!";
        }

        public string DeleteState(int id)
        {
            var state = _context.States.Find(id);
            if (state != null)
            {
                _context.States.Remove(state);
                _context.SaveChanges();
                return "State Deleted Successfully!";
            }
            return "State Not Found!";
        }

    }
}
