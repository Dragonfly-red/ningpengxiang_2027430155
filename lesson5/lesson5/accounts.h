#pragma once
class accounts
{
public:
	long account;
	long password;
public:
	accounts();
	~accounts();
	void login();
	void logout();
	void remake_password();
};

