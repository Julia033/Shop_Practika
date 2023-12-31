
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel;

namespace Shop1.Entities
{

using System;
    using System.Collections.Generic;
    public partial class Books_Catalog
    {

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Books_Catalog()
    {

        this.Admissions = new HashSet<Admission>();

        this.Bookings = new HashSet<Booking>();

    }


    public System.Guid Book_id { get; set; }

    [DisplayName("Название книги")]
     public string Book_name { get; set; }

    [DisplayName("Возрастное ограничение")]
    public string Book_age_categ { get; set; }

    [DisplayName("Количество")]
    public int Book_count { get; set; }

    [DisplayName("Цена")]
    public int Book_price { get; set; }

    public int Genre_code { get; set; }

    public int Author_code { get; set; }

    public int Book_pub_house_code { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Admission> Admissions { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Booking> Bookings { get; set; }

    public virtual Author Author1 { get; set; }

    public virtual Genre Genre1 { get; set; }

    public virtual Pub_houses Pub_houses { get; set; }

}

}
