<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>log4net</Namespace>
</Query>

void Main()
{
	MyExtensions.SetupLog4Net();
	LogManager.GetLogger("Chaining Tasks").Info(nameof(Main));

	Task taskOne = /* (3) */ new Task(new Action(TaskOneFunction));

	/* (4) */
	taskOne.ContinueWith(new Action<Task>(TaskTwoFunctionWrapper));

	taskOne.Start();
}

/* (1) */
public void TaskOneFunction()
{
	LogManager.GetLogger("Chaining Tasks").Info(nameof(TaskOneFunction));
}

/* (2) */
public void TaskTwoFunction()
{
	LogManager.GetLogger("Chaining Tasks").Info(nameof(TaskTwoFunction));
}

/* (5) */
public void TaskTwoFunctionWrapper(Task antecedent)
{
	TaskTwoFunction();
}

