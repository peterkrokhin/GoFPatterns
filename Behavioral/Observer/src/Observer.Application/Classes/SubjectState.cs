using System;

namespace Observer.Application
{
    public class State : IEquatable<State>
    {
        private string Message{ get; set; }
        public State(string message) => Message = message;

        public override string ToString()
        {
            return Message;
        }
        public override bool Equals(object other) => Equals(other as State);

        public override int GetHashCode()
        {
            int hashCode = Message.GetHashCode();
            hashCode = 7 * hashCode;
            return hashCode;
        }

        public bool Equals(State other)
        {
            if (this == other) return true;
            if (other == null) return false;
            if (this.Message == other.Message) return true;
            return false;
        }
    }
}
