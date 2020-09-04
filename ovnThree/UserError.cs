using System;
using System.Collections.Generic;

namespace ovnThree
{
   
    public abstract class UserError
    {
        public string UserErrorMSG { get; set; }
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public NumericInputError()
        {
            UEMessage();
        }
        public override string UEMessage()
        {
            return $"You tried to use a numeric input in a text only field. This fired an error";
        }
    }
    class TextInputError : UserError
    {
        public TextInputError()
        {
            UEMessage();
        }
        public override string UEMessage()
        {
            return $"You tried to use a text input in a numericonly only field. This fired an error";
        }
    }

    class InputErrorFirst : UserError
    {
        public InputErrorFirst()
        {
            UEMessage();
        }
        public override string UEMessage()
        {
            return $"Trial and Error ONE";
        }
    }
    class InputErrorSecond : UserError
    {
        public InputErrorSecond()
        {
            UEMessage();
        }
        public override string UEMessage()
        {
            return $"Trial and Error TWO";
        }
    }
    class InputErrorThird : UserError
    {
        public InputErrorThird()
        {
            UEMessage();
        }
        public override string UEMessage()
        {
            return $"Trial and Error THREE";
        }
    }
}