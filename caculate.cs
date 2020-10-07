piublic static class caculate{
	public int add(int a,int b)
	{
		return a+b;
	}
	public int max(int a,int b)
	{
		if(a>b)
			return a;
		else
			return b;
	}
	public void swap(int &a, int &b)
	{
		int temp=a;
		a=b;
		b=temp;
	}
}
