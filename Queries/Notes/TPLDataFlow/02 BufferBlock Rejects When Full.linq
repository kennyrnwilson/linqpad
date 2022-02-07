<Query Kind="Statements">
  <NuGetReference>System.Threading.Tasks.Dataflow</NuGetReference>
  <Namespace>static System.Console</Namespace>
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

var b = new BufferBlock<int>(new DataflowBlockOptions {BoundedCapacity = 1});
WriteLine(b.Post(1));
WriteLine(b.Post(2));

