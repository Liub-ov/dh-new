using System;
namespace DH_C
{
    public class User
	{
		private int u;
		private int Key;
		public int U;
		public User(int u)
		{
			this.u = u;
		}
		int p = 7;
		int g = 3;
		public int getN(User a, User b)
		{
			int A, k;
			A = (int)(Math.Pow(g, a.u));
			A = A % p;
			k = setKey(A, b);
			return k;
		}
		int setKey(int U, User user)
		{
			Key = (int)Math.Pow(U, user.u);
			Key = Key % p;
			return Key;
		}

	}
};
