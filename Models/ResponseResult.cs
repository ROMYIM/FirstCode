using FirstCode.Constants;
namespace FirstCode.Models
{
    public class ResponseResult
    {
        public int Code { get; set; }
        public object Info { get; set; }

        public ResponseResult(int code, object info)
        {
            Code = code;
            Info = info;
        }

        public ResponseResult(int resultCode) => Code = resultCode;

        public ResponseResult SetResult(ResultType type)
        {
            switch (type)
            {
                case ResultType.SUCCESS:
                Code = ResultCode.ResponseSucessCode;
                break;
                case ResultType.FAIL:
                Code = ResultCode.ResponseFailCode;
                break;
                default:
                Code = ResultCode.ResponseInfoCode;
                break;
            }
            return this;
        }
    }

    public enum ResultType
    {
        SUCCESS, FAIL, INFO
    }
}