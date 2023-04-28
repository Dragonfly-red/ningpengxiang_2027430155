#pragma once
#include "User.h"
class VIP_User :
    public User
{
public:
    VIP_User();
    ~VIP_User();
    void start_alone_task();
    void start_multi_task();
};

