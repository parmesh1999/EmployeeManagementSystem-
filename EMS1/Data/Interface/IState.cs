using EMS1.Models;

namespace EMS1.Data.Interface
{
    public interface IState
    {
        List<State> GetAllStates();
        State GetState(int id);
        String AddState(State state);
        String UpdateState(int id, State state);
        String DeleteState(int id);
    }
}
