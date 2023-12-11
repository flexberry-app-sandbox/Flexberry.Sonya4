﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Sonya4
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Расход денег.
    /// </summary>
    // *** Start programmer edit section *** (РасходДенег CustomAttributes)

    // *** End programmer edit section *** (РасходДенег CustomAttributes)
    [AutoAltered()]
    [Caption("Расход денег")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РасходДенегE", new string[] {
            "ID as \'ID\'",
            "Дата as \'Дата\'",
            "Банк as \'Банк\'",
            "Счет as \'Счет\'",
            "ИНН as \'ИНН\'",
            "БИК as \'БИК\'",
            "Сумма as \'Сумма\'"})]
    [AssociatedDetailViewAttribute("РасходДенегE", "СоставМатериалы", "СоставМатериалыE", true, "", "Состав материалы", true, new string[] {
            ""})]
    [View("РасходДенегL", new string[] {
            "ID as \'ID\'",
            "Дата as \'Дата\'",
            "Банк as \'Банк\'",
            "Счет as \'Счет\'",
            "ИНН as \'ИНН\'",
            "БИК as \'БИК\'",
            "Сумма as \'Сумма\'"})]
    public class РасходДенег : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private System.DateTime fДата;
        
        private IIS.Sonya4.Банк fБанк;
        
        private int fСчет;
        
        private int fИНН;
        
        private int fБИК;
        
        private int fСумма;
        
        private IIS.Sonya4.Поставщики fПоставщики;
        
        private IIS.Sonya4.DetailArrayOfСоставМатериалы fСоставМатериалы;
        
        // *** Start programmer edit section *** (РасходДенег CustomMembers)

        // *** End programmer edit section *** (РасходДенег CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.ID CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.ID Get start)

                // *** End programmer edit section *** (РасходДенег.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (РасходДенег.ID Get end)

                // *** End programmer edit section *** (РасходДенег.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.ID Set start)

                // *** End programmer edit section *** (РасходДенег.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (РасходДенег.ID Set end)

                // *** End programmer edit section *** (РасходДенег.ID Set end)
            }
        }
        
        /// <summary>
        /// Банк.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.Банк CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.Банк CustomAttributes)
        public virtual IIS.Sonya4.Банк Банк
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.Банк Get start)

                // *** End programmer edit section *** (РасходДенег.Банк Get start)
                IIS.Sonya4.Банк result = this.fБанк;
                // *** Start programmer edit section *** (РасходДенег.Банк Get end)

                // *** End programmer edit section *** (РасходДенег.Банк Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.Банк Set start)

                // *** End programmer edit section *** (РасходДенег.Банк Set start)
                this.fБанк = value;
                // *** Start programmer edit section *** (РасходДенег.Банк Set end)

                // *** End programmer edit section *** (РасходДенег.Банк Set end)
            }
        }
        
        /// <summary>
        /// БИК.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.БИК CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.БИК CustomAttributes)
        public virtual int БИК
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.БИК Get start)

                // *** End programmer edit section *** (РасходДенег.БИК Get start)
                int result = this.fБИК;
                // *** Start programmer edit section *** (РасходДенег.БИК Get end)

                // *** End programmer edit section *** (РасходДенег.БИК Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.БИК Set start)

                // *** End programmer edit section *** (РасходДенег.БИК Set start)
                this.fБИК = value;
                // *** Start programmer edit section *** (РасходДенег.БИК Set end)

                // *** End programmer edit section *** (РасходДенег.БИК Set end)
            }
        }
        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.Дата CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.Дата Get start)

                // *** End programmer edit section *** (РасходДенег.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (РасходДенег.Дата Get end)

                // *** End programmer edit section *** (РасходДенег.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.Дата Set start)

                // *** End programmer edit section *** (РасходДенег.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (РасходДенег.Дата Set end)

                // *** End programmer edit section *** (РасходДенег.Дата Set end)
            }
        }
        
        /// <summary>
        /// ИНН.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.ИНН CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.ИНН CustomAttributes)
        public virtual int ИНН
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.ИНН Get start)

                // *** End programmer edit section *** (РасходДенег.ИНН Get start)
                int result = this.fИНН;
                // *** Start programmer edit section *** (РасходДенег.ИНН Get end)

                // *** End programmer edit section *** (РасходДенег.ИНН Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.ИНН Set start)

                // *** End programmer edit section *** (РасходДенег.ИНН Set start)
                this.fИНН = value;
                // *** Start programmer edit section *** (РасходДенег.ИНН Set end)

                // *** End programmer edit section *** (РасходДенег.ИНН Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.Сумма CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.Сумма CustomAttributes)
        public virtual int Сумма
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.Сумма Get start)

                // *** End programmer edit section *** (РасходДенег.Сумма Get start)
                int result = this.fСумма;
                // *** Start programmer edit section *** (РасходДенег.Сумма Get end)

                // *** End programmer edit section *** (РасходДенег.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.Сумма Set start)

                // *** End programmer edit section *** (РасходДенег.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (РасходДенег.Сумма Set end)

                // *** End programmer edit section *** (РасходДенег.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Счет.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.Счет CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.Счет CustomAttributes)
        public virtual int Счет
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.Счет Get start)

                // *** End programmer edit section *** (РасходДенег.Счет Get start)
                int result = this.fСчет;
                // *** Start programmer edit section *** (РасходДенег.Счет Get end)

                // *** End programmer edit section *** (РасходДенег.Счет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.Счет Set start)

                // *** End programmer edit section *** (РасходДенег.Счет Set start)
                this.fСчет = value;
                // *** Start programmer edit section *** (РасходДенег.Счет Set end)

                // *** End programmer edit section *** (РасходДенег.Счет Set end)
            }
        }
        
        /// <summary>
        /// Расход денег.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.Поставщики CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.Поставщики CustomAttributes)
        [PropertyStorage(new string[] {
                "Поставщики"})]
        [NotNull()]
        public virtual IIS.Sonya4.Поставщики Поставщики
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.Поставщики Get start)

                // *** End programmer edit section *** (РасходДенег.Поставщики Get start)
                IIS.Sonya4.Поставщики result = this.fПоставщики;
                // *** Start programmer edit section *** (РасходДенег.Поставщики Get end)

                // *** End programmer edit section *** (РасходДенег.Поставщики Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.Поставщики Set start)

                // *** End programmer edit section *** (РасходДенег.Поставщики Set start)
                this.fПоставщики = value;
                // *** Start programmer edit section *** (РасходДенег.Поставщики Set end)

                // *** End programmer edit section *** (РасходДенег.Поставщики Set end)
            }
        }
        
        /// <summary>
        /// Расход денег.
        /// </summary>
        // *** Start programmer edit section *** (РасходДенег.СоставМатериалы CustomAttributes)

        // *** End programmer edit section *** (РасходДенег.СоставМатериалы CustomAttributes)
        public virtual IIS.Sonya4.DetailArrayOfСоставМатериалы СоставМатериалы
        {
            get
            {
                // *** Start programmer edit section *** (РасходДенег.СоставМатериалы Get start)

                // *** End programmer edit section *** (РасходДенег.СоставМатериалы Get start)
                if ((this.fСоставМатериалы == null))
                {
                    this.fСоставМатериалы = new IIS.Sonya4.DetailArrayOfСоставМатериалы(this);
                }
                IIS.Sonya4.DetailArrayOfСоставМатериалы result = this.fСоставМатериалы;
                // *** Start programmer edit section *** (РасходДенег.СоставМатериалы Get end)

                // *** End programmer edit section *** (РасходДенег.СоставМатериалы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РасходДенег.СоставМатериалы Set start)

                // *** End programmer edit section *** (РасходДенег.СоставМатериалы Set start)
                this.fСоставМатериалы = value;
                // *** Start programmer edit section *** (РасходДенег.СоставМатериалы Set end)

                // *** End programmer edit section *** (РасходДенег.СоставМатериалы Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РасходДенегE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РасходДенегE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РасходДенегE", typeof(IIS.Sonya4.РасходДенег));
                }
            }
            
            /// <summary>
            /// "РасходДенегL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РасходДенегL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РасходДенегL", typeof(IIS.Sonya4.РасходДенег));
                }
            }
        }
    }
}
