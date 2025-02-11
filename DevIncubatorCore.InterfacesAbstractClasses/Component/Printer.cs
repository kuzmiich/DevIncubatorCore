﻿namespace DevIncubatorCore.InterfacesAbstractClasses.Component
{
    internal abstract class Printer
    {
        protected Printer(string type, bool isPresence)
        {
            Type = type;
            IsPresence = isPresence;
        }

        public string Type { get; }
        protected bool IsPresence { get; }

        public abstract void Start(string text);
    }
}