namespace FirstCode.Constants
{
    struct ErrorMessage
    {
        public const string EmptyId = "id is required";
        public const string EmptyName = "name is required";
        public const string EmptyPassword = "password is required";
        public const string EmptyIdentity = "identity is required";
        public const string EmptyUser = "there is no user";
    }

    struct ResultCode
    {
        public const int ResponseFailCode = -1;
        public const int ResponseInfoCode = 1;
        public const int ResponseSucessCode = 0;
    }
}