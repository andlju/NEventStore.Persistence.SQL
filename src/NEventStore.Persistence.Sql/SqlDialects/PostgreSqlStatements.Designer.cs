﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEventStore.Persistence.Sql.SqlDialects {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PostgreSqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PostgreSqlStatements() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NEventStore.Persistence.Sql.SqlDialects.PostgreSqlStatements", typeof(PostgreSqlStatements).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE Commits
        ///(
        ///    BucketId varchar(40) NOT NULL,
        ///    StreamId char(40) NOT NULL,
        ///    StreamIdOriginal varchar(1000) NOT NULL,
        ///    StreamRevision int NOT NULL CHECK (StreamRevision &gt; 0),
        ///    Items smallint NOT NULL CHECK (Items &gt; 0),
        ///    CommitId uuid NOT NULL,
        ///    CommitSequence int NOT NULL CHECK (CommitSequence &gt; 0),
        ///    CommitStamp timestamp NOT NULL,
        ///    CheckpointNumber SERIAL NOT NULL,
        ///    Headers bytea NULL,
        ///    Payload bytea NOT NULL,
        ///    CONSTRAINT PK_Commits PRIMARY KEY (Chec [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitializeStorage {
            get {
                return ResourceManager.GetString("InitializeStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO Commits
        ///     ( BucketId, StreamId, StreamIdOriginal, CommitId, CommitSequence, StreamRevision, Items, CommitStamp, Headers, Payload )
        ///VALUES (@BucketId, @StreamId, @StreamIdOriginal, @CommitId, @CommitSequence, @StreamRevision, @Items, @CommitStamp, @Headers, @Payload)
        ///RETURNING CheckpointNumber;.
        /// </summary>
        internal static string PersistCommits {
            get {
                return ResourceManager.GetString("PersistCommits", resourceCulture);
            }
        }
    }
}
