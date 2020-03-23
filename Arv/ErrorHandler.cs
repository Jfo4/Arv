using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    abstract class UserError
    {
        //public UserError()
        //{
        //}

        public virtual string UEMessage()
        {
            return "Error: ";
        }
    }
    class NumericInputError : UserError
    {
        private int ErrNo;

        public NumericInputError(int errno)
        {
            ErrNo = errno;
        }
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric-only field. This fired an error!";
            //return base.UEMessage() + "You tried to use a text input in a numeric-only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {
        private string ErrMsg;

        public TextInputError(string errmsg)
        {
            ErrMsg = errmsg;
        }
        public override string UEMessage()
        {
            return base.UEMessage() + ErrMsg.ToString();
        }
    }
}
