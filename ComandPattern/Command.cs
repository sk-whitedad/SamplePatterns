﻿namespace CommandPattern
{
    public interface Command
    {
        public void execute();
        public void undo();
    }
}
