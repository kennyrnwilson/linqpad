<Query Kind="Statements">
  <NuGetReference>System.Threading.Tasks.Dataflow</NuGetReference>
  <Namespace>static System.Console</Namespace>
  <Namespace>static System.Threading.Thread</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

BufferBlock<int> buffer = new BufferBlock<int>();

var consumerTask = Task.Factory.StartNew(() =>
{
	while (true)
	{
		int item = buffer.Receive();
		WriteLine($"Consumed item {item}");
	}
});

var producerTask = Task.Factory.StartNew(() =>
{
	for (int i = 0; i < 10; i++)
	{
		buffer.Post(i);
		Sleep(1000);
	}
});


Task.WaitAll(consumerTask, producerTask);
