<Query Kind="Statements">
  <NuGetReference>System.Threading.Tasks.Dataflow</NuGetReference>
  <Namespace>static System.Console</Namespace>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

var b = new BufferBlock<int>();
b.Post(1);
b.Post(2);

WriteLine(b.Receive());
WriteLine(b.Receive());
WriteLine(b.Receive());
WriteLine("All received");
