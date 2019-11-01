using System;
using System.Collections.Generic;
using System.Text;

namespace EncapInheritPoly
{
    //3.4.1
    abstract class UserError
    {
        //3.4.2
        public abstract string UEMessage();
    }

    //3.4.3
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            //3.4.4
            return "You tried to use a numeric input in a text-only field. This fired an ERROR!";
        }
    }

    //3.4.5
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            //3.4.6
            return "You tried to use a text input in a numeric-only field. This fired an ERROR!";
        }
    }

    //3.4.9
    class NonBooleanInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a non-boolean input in a boolean-only field. This fired an ERROR!";
        }
    }

    //3.4.9
    class TooBigInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an input that was too big. This fired an ERROR!";
        }
    }

    //3.4.9
    class NegativeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an input that was negative. This fired an ERROR!";
        }
    }
}
