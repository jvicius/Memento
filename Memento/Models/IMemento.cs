using System;

namespace Memento.Models
{
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}