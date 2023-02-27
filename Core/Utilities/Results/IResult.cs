using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } //sadece okunabilir bir yapı , başarılı sonucu verir.
        string Message { get; }  //işlem başarılı veya başarısız ise kullanıcıya dönen mesaj.
    }
}
