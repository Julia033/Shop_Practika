
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Shop1.Entities
{

using System;
    using System.Collections.Generic;
    
public partial class Admission
{

    public int Admission_number { get; set; }

    public System.Guid Book_id { get; set; }

    public System.DateTime Date_of_adm { get; set; }

    public int Book_count { get; set; }



    public virtual Books_Catalog Books_Catalog { get; set; }

}

}
