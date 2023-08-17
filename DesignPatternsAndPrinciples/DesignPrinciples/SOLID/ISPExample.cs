using System;
using DotnetTraining.DesignPrinciples.SOLID.Interfaces;

namespace DotnetTraining.SOLID
{
	public class ISPExample
	{
		public void RunISP()
        {
            TeamLead tl = new TeamLead();
            Developer dev = new Developer();
            tl.AssignTask();
            dev.WorkOnTask();
        }
	}

    public class TeamLead : ILead, IDeveloper
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateSubTask()
        {
            throw new NotImplementedException();
        }

        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {
            throw new NotImplementedException();
        }

        public void CreateSubTask()
        {
            throw new NotImplementedException();
        }
    }

    public class Developer : IDeveloper
    {
        public void WorkOnTask()
        {
            throw new NotImplementedException();
        }
    }
}

