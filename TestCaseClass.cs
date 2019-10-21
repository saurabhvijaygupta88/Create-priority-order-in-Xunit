// First parameter is for PriorityOrderer namespace name and second parameter is for unit test namespace name.
[TestCaseOrderer("Test.PriorityOrderer", "Test.UnitTesting")]
public class Test : IClassFixture<BaseTest>
{
	[Fact, TestPriority(1)]
	public async Task Validate_Positive_Test()
	{ 
		//write your test case here.
	}
}