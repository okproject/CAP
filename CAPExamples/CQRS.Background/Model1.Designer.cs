﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace CQRS.Background
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CAP_CQRSEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CAP_CQRSEntities object using the connection string found in the 'CAP_CQRSEntities' section of the application configuration file.
        /// </summary>
        public CAP_CQRSEntities() : base("name=CAP_CQRSEntities", "CAP_CQRSEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CAP_CQRSEntities object.
        /// </summary>
        public CAP_CQRSEntities(string connectionString) : base(connectionString, "CAP_CQRSEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CAP_CQRSEntities object.
        /// </summary>
        public CAP_CQRSEntities(EntityConnection connection) : base(connection, "CAP_CQRSEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AccountBalance> AccountBalances
        {
            get
            {
                if ((_AccountBalances == null))
                {
                    _AccountBalances = base.CreateObjectSet<AccountBalance>("AccountBalances");
                }
                return _AccountBalances;
            }
        }
        private ObjectSet<AccountBalance> _AccountBalances;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AccountBalances EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAccountBalances(AccountBalance accountBalance)
        {
            base.AddObject("AccountBalances", accountBalance);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CAP_CQRSModel", Name="AccountBalance")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AccountBalance : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AccountBalance object.
        /// </summary>
        /// <param name="account">Initial value of the Account property.</param>
        /// <param name="balance">Initial value of the Balance property.</param>
        public static AccountBalance CreateAccountBalance(global::System.String account, global::System.Decimal balance)
        {
            AccountBalance accountBalance = new AccountBalance();
            accountBalance.Account = account;
            accountBalance.Balance = balance;
            return accountBalance;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Account
        {
            get
            {
                return _Account;
            }
            set
            {
                if (_Account != value)
                {
                    OnAccountChanging(value);
                    ReportPropertyChanging("Account");
                    _Account = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Account");
                    OnAccountChanged();
                }
            }
        }
        private global::System.String _Account;
        partial void OnAccountChanging(global::System.String value);
        partial void OnAccountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                OnBalanceChanging(value);
                ReportPropertyChanging("Balance");
                _Balance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Balance");
                OnBalanceChanged();
            }
        }
        private global::System.Decimal _Balance;
        partial void OnBalanceChanging(global::System.Decimal value);
        partial void OnBalanceChanged();

        #endregion
    
    }

    #endregion
    
}