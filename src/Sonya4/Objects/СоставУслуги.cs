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
    /// Состав услуги.
    /// </summary>
    // *** Start programmer edit section *** (СоставУслуги CustomAttributes)

    // *** End programmer edit section *** (СоставУслуги CustomAttributes)
    [AutoAltered()]
    [Caption("Состав услуги")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СоставУслугиE", new string[] {
            "Количество as \'Количество\'"})]
    public class СоставУслуги : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private IIS.Sonya4.Услуги fУслуги;
        
        private IIS.Sonya4.ПриходДенег fПриходДенег;
        
        // *** Start programmer edit section *** (СоставУслуги CustomMembers)

        // *** End programmer edit section *** (СоставУслуги CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (СоставУслуги.Количество CustomAttributes)

        // *** End programmer edit section *** (СоставУслуги.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (СоставУслуги.Количество Get start)

                // *** End programmer edit section *** (СоставУслуги.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (СоставУслуги.Количество Get end)

                // *** End programmer edit section *** (СоставУслуги.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СоставУслуги.Количество Set start)

                // *** End programmer edit section *** (СоставУслуги.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (СоставУслуги.Количество Set end)

                // *** End programmer edit section *** (СоставУслуги.Количество Set end)
            }
        }
        
        /// <summary>
        /// Состав услуги.
        /// </summary>
        // *** Start programmer edit section *** (СоставУслуги.Услуги CustomAttributes)

        // *** End programmer edit section *** (СоставУслуги.Услуги CustomAttributes)
        [PropertyStorage(new string[] {
                "Услуги"})]
        [NotNull()]
        public virtual IIS.Sonya4.Услуги Услуги
        {
            get
            {
                // *** Start programmer edit section *** (СоставУслуги.Услуги Get start)

                // *** End programmer edit section *** (СоставУслуги.Услуги Get start)
                IIS.Sonya4.Услуги result = this.fУслуги;
                // *** Start programmer edit section *** (СоставУслуги.Услуги Get end)

                // *** End programmer edit section *** (СоставУслуги.Услуги Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СоставУслуги.Услуги Set start)

                // *** End programmer edit section *** (СоставУслуги.Услуги Set start)
                this.fУслуги = value;
                // *** Start programmer edit section *** (СоставУслуги.Услуги Set end)

                // *** End programmer edit section *** (СоставУслуги.Услуги Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Sonya4.ПриходДенег.
        /// </summary>
        // *** Start programmer edit section *** (СоставУслуги.ПриходДенег CustomAttributes)

        // *** End programmer edit section *** (СоставУслуги.ПриходДенег CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ПриходДенег"})]
        public virtual IIS.Sonya4.ПриходДенег ПриходДенег
        {
            get
            {
                // *** Start programmer edit section *** (СоставУслуги.ПриходДенег Get start)

                // *** End programmer edit section *** (СоставУслуги.ПриходДенег Get start)
                IIS.Sonya4.ПриходДенег result = this.fПриходДенег;
                // *** Start programmer edit section *** (СоставУслуги.ПриходДенег Get end)

                // *** End programmer edit section *** (СоставУслуги.ПриходДенег Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СоставУслуги.ПриходДенег Set start)

                // *** End programmer edit section *** (СоставУслуги.ПриходДенег Set start)
                this.fПриходДенег = value;
                // *** Start programmer edit section *** (СоставУслуги.ПриходДенег Set end)

                // *** End programmer edit section *** (СоставУслуги.ПриходДенег Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СоставУслугиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СоставУслугиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СоставУслугиE", typeof(IIS.Sonya4.СоставУслуги));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of СоставУслуги.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfСоставУслуги CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfСоставУслуги CustomAttributes)
    public class DetailArrayOfСоставУслуги : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Sonya4.DetailArrayOfСоставУслуги members)

        // *** End programmer edit section *** (IIS.Sonya4.DetailArrayOfСоставУслуги members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type СоставУслуги by index.
        /// </summary>
        /// <summary>
        /// Adds object with type СоставУслуги.
        /// </summary>
        public DetailArrayOfСоставУслуги(IIS.Sonya4.ПриходДенег fПриходДенег) : 
                base(typeof(СоставУслуги), ((ICSSoft.STORMNET.DataObject)(fПриходДенег)))
        {
        }
        
        public IIS.Sonya4.СоставУслуги this[int index]
        {
            get
            {
                return ((IIS.Sonya4.СоставУслуги)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Sonya4.СоставУслуги dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
