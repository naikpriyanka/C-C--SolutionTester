#include<iostream>
using namespace std;

bool possible(int a[])
{
	for(int i=0; i<26; i++)
		if(a[i]<0)
			return 0;
	return 1;
}


int main()
{
	int t;
	cin>>t;
	char s[50000];
	while(t--)
	{
		int count[26]={0};
		cin>>s;
		for(int i=0; s[i]; i++)
			count[s[i]-'a']++;
		cin>>s;
		for(int i=0; s[i]; i++)
			count[s[i]-'a']++;

		int n;
		cin>>n;
		while(n--)
		{
			cin>>s;
			for(int i=0; s[i]; i++)
				count[s[i]-'a']--;
		}
		if(possible(count))
			cout<<"YES"<<endl;
		else
			cout<<"NO"<<endl;
	}
	return 0;
}