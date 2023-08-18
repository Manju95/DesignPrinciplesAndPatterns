using System;
namespace DesignPatternsAndPrinciples.DesignPatterns.BehaviouralPatterns
{
	public class CommandPattern
	{
		public void Run()
		{
			Reciever reciever = new Reciever();
			Command command = new ConcreteCommand(reciever);
			Invoker invoker = new Invoker();

			invoker.SetCommand(command);
			invoker.ExecuteCommand();
		}
	}

	public class Reciever
	{
		public void Action()
		{
			Console.WriteLine("Receiver invoked");
		}
	}

	public abstract class Command
	{
		protected Reciever _reciever;

		public Command(Reciever reciever)
		{
			_reciever = reciever;
		}

		public abstract void Execute();
	}

    public class ConcreteCommand : Command
    {
		public ConcreteCommand(Reciever reciever) : base(reciever)
		{

		}

        public override void Execute()
        {
			_reciever.Action();
        }
    }

	public class Invoker
	{
		Command _command;

		public void SetCommand(Command command)
		{
			_command = command;
		}

		public void ExecuteCommand()
		{
			_command.Execute();
		}
	}
}

