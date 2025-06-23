using EMS1.Models;

namespace EMS1.Data.Interface
{
    public interface IState
    {
        List<State> GetAllStates();
        String AddState(State state);
        String UpdateState(State state);
        String DeleteState(int id);
    }
}
