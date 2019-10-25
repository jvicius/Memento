using System;

namespace Memento.Models
{
    public class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        public void SetState(string value)
        {
            this._state = value;
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        public string GetState()
        {
            Console.WriteLine($"Originator: My Current state is: {_state}");
            return this._state;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }

    }
}
