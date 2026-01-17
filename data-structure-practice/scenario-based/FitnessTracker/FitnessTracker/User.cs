using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker {
    internal class User {
        private string name;
        private int stepCount;

        public User(string name, int stepCount) {
            this.name = name;
            this.stepCount = stepCount;
        }

        public string Name { get => name; set => name = value; }
        public int StepCount { get => stepCount; set => stepCount = value; }

        public override string ToString() {
            return $"Name: {Name} | StepCount: {StepCount}";
        }
    }
}
