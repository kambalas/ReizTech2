public class Branch
{
	private List<Branch> branches;

	public Branch()
	{
		this.branches = new List<Branch>();
	}

	public void AddBranch(Branch branch)
	{
		branches.Add(branch);
	}

	public List<Branch> GetBranches()
	{
		return branches;
	}
}

public class DepthCalculator
{
	public static int CalculateDepth(Branch branch)
	{
		if (branch.GetBranches().Count == 0)
		{
			return 1;
		}
		else
		{
			int maxDepth = 0;
			foreach (Branch b in branch.GetBranches())
			{
				int depth = CalculateDepth(b);
				if (depth > maxDepth)
				{
					maxDepth = depth;
				}
			}
			return maxDepth + 1;
		}
	}

	public static void Main(string[] args)
	{
		Branch root = new Branch();
		Branch branch1 = new Branch();
		Branch branch2 = new Branch();
		Branch branch3 = new Branch();
		Branch branch4 = new Branch();
		Branch branch5 = new Branch();
		Branch branch6 = new Branch();
		Branch branch7 = new Branch();
		Branch branch8 = new Branch();
		Branch branch9 = new Branch();
		Branch branch10 = new Branch();
		Branch branch11 = new Branch();
		Branch branch12 = new Branch();

		root.AddBranch(branch1);
		root.AddBranch(branch2);
		root.AddBranch(branch3);
		branch1.AddBranch(branch4);
		branch1.AddBranch(branch5);
		branch1.AddBranch(branch6);
		branch2.AddBranch(branch7);
		branch2.AddBranch(branch8);
		branch2.AddBranch(branch9);
		branch3.AddBranch(branch10);
		branch3.AddBranch(branch11);
		branch11.AddBranch(branch12);

		int depth = CalculateDepth(root);
		Console.WriteLine("Depth: " + depth);
	}
}
