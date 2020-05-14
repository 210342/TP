/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using ;

namespace ObjectTypeTest
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ComplexObjectType_ChildMethod Method.
        /// </summary>
        public const uint ComplexObjectType_ChildMethod = 10;

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType_ChildMethod Method.
        /// </summary>
        public const uint DerivedFromComplexObjectType_ChildMethod = 25;

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_ChildMethod Method.
        /// </summary>
        public const uint InstanceOfDerivedFromComplexObjectType_ChildMethod = 39;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the ComplexObjectType_ChildObject Object.
        /// </summary>
        public const uint ComplexObjectType_ChildObject = 2;

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType Object.
        /// </summary>
        public const uint InstanceOfDerivedFromComplexObjectType = 30;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ComplexObjectType ObjectType.
        /// </summary>
        public const uint ComplexObjectType = 1;

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType ObjectType.
        /// </summary>
        public const uint DerivedFromComplexObjectType = 16;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ComplexObjectType_BrowseName4node66 Variable.
        /// </summary>
        public const uint ComplexObjectType_BrowseName4node66 = 3;

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildVariable Variable.
        /// </summary>
        public const uint ComplexObjectType_ChildVariable = 43;

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildVariable_EURange Variable.
        /// </summary>
        public const uint ComplexObjectType_ChildVariable_EURange = 47;

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildMethod_InputArguments Variable.
        /// </summary>
        public const uint ComplexObjectType_ChildMethod_InputArguments = 11;

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildMethod_OutputArguments Variable.
        /// </summary>
        public const uint ComplexObjectType_ChildMethod_OutputArguments = 12;

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType_BrowseName4node66 Variable.
        /// </summary>
        public const uint DerivedFromComplexObjectType_BrowseName4node66 = 18;

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType_ChildVariable_EURange Variable.
        /// </summary>
        public const uint DerivedFromComplexObjectType_ChildVariable_EURange = 53;

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_BrowseName4node66 Variable.
        /// </summary>
        public const uint InstanceOfDerivedFromComplexObjectType_BrowseName4node66 = 32;

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_ChildVariable Variable.
        /// </summary>
        public const uint InstanceOfDerivedFromComplexObjectType_ChildVariable = 55;

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_ChildVariable_EURange Variable.
        /// </summary>
        public const uint InstanceOfDerivedFromComplexObjectType_ChildVariable_EURange = 59;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ComplexObjectType_ChildMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_ChildMethod = new ExpandedNodeId(ObjectTypeTest.Methods.ComplexObjectType_ChildMethod, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType_ChildMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId DerivedFromComplexObjectType_ChildMethod = new ExpandedNodeId(ObjectTypeTest.Methods.DerivedFromComplexObjectType_ChildMethod, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_ChildMethod Method.
        /// </summary>
        public static readonly ExpandedNodeId InstanceOfDerivedFromComplexObjectType_ChildMethod = new ExpandedNodeId(ObjectTypeTest.Methods.InstanceOfDerivedFromComplexObjectType_ChildMethod, ObjectTypeTest.Namespaces.cas);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the ComplexObjectType_ChildObject Object.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_ChildObject = new ExpandedNodeId(ObjectTypeTest.Objects.ComplexObjectType_ChildObject, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType Object.
        /// </summary>
        public static readonly ExpandedNodeId InstanceOfDerivedFromComplexObjectType = new ExpandedNodeId(ObjectTypeTest.Objects.InstanceOfDerivedFromComplexObjectType, ObjectTypeTest.Namespaces.cas);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ComplexObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType = new ExpandedNodeId(ObjectTypeTest.ObjectTypes.ComplexObjectType, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DerivedFromComplexObjectType = new ExpandedNodeId(ObjectTypeTest.ObjectTypes.DerivedFromComplexObjectType, ObjectTypeTest.Namespaces.cas);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ComplexObjectType_BrowseName4node66 Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_BrowseName4node66 = new ExpandedNodeId(ObjectTypeTest.Variables.ComplexObjectType_BrowseName4node66, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildVariable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_ChildVariable = new ExpandedNodeId(ObjectTypeTest.Variables.ComplexObjectType_ChildVariable, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildVariable_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_ChildVariable_EURange = new ExpandedNodeId(ObjectTypeTest.Variables.ComplexObjectType_ChildVariable_EURange, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildMethod_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_ChildMethod_InputArguments = new ExpandedNodeId(ObjectTypeTest.Variables.ComplexObjectType_ChildMethod_InputArguments, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the ComplexObjectType_ChildMethod_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComplexObjectType_ChildMethod_OutputArguments = new ExpandedNodeId(ObjectTypeTest.Variables.ComplexObjectType_ChildMethod_OutputArguments, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType_BrowseName4node66 Variable.
        /// </summary>
        public static readonly ExpandedNodeId DerivedFromComplexObjectType_BrowseName4node66 = new ExpandedNodeId(ObjectTypeTest.Variables.DerivedFromComplexObjectType_BrowseName4node66, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the DerivedFromComplexObjectType_ChildVariable_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DerivedFromComplexObjectType_ChildVariable_EURange = new ExpandedNodeId(ObjectTypeTest.Variables.DerivedFromComplexObjectType_ChildVariable_EURange, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_BrowseName4node66 Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstanceOfDerivedFromComplexObjectType_BrowseName4node66 = new ExpandedNodeId(ObjectTypeTest.Variables.InstanceOfDerivedFromComplexObjectType_BrowseName4node66, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_ChildVariable Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstanceOfDerivedFromComplexObjectType_ChildVariable = new ExpandedNodeId(ObjectTypeTest.Variables.InstanceOfDerivedFromComplexObjectType_ChildVariable, ObjectTypeTest.Namespaces.cas);

        /// <summary>
        /// The identifier for the InstanceOfDerivedFromComplexObjectType_ChildVariable_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstanceOfDerivedFromComplexObjectType_ChildVariable_EURange = new ExpandedNodeId(ObjectTypeTest.Variables.InstanceOfDerivedFromComplexObjectType_ChildVariable_EURange, ObjectTypeTest.Namespaces.cas);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the BrowseName4node66 component.
        /// </summary>
        public const string BrowseName4node66 = "ChildProperty";

        /// <summary>
        /// The BrowseName for the ChildMethod component.
        /// </summary>
        public const string ChildMethod = "ChildMethod";

        /// <summary>
        /// The BrowseName for the ChildObject component.
        /// </summary>
        public const string ChildObject = "ChildObject";

        /// <summary>
        /// The BrowseName for the ChildVariable component.
        /// </summary>
        public const string ChildVariable = "ChildVariable";

        /// <summary>
        /// The BrowseName for the ComplexObjectType component.
        /// </summary>
        public const string ComplexObjectType = "ComplexObjectType";

        /// <summary>
        /// The BrowseName for the DerivedFromComplexObjectType component.
        /// </summary>
        public const string DerivedFromComplexObjectType = "DerivedFromComplexObjectType";

        /// <summary>
        /// The BrowseName for the InstanceOfDerivedFromComplexObjectType component.
        /// </summary>
        public const string InstanceOfDerivedFromComplexObjectType = "InstanceOfDerivedFromComplexObjectType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the cas namespace (.NET code namespace is 'ObjectTypeTest').
        /// </summary>
        public const string cas = "http://cas.eu/UA/CommServer/UnitTests/ObjectTypeTest";

        /// <summary>
        /// The URI for the ua namespace (.NET code namespace is '').
        /// </summary>
        public const string ua = "http://opcfoundation.org/UA/";
    }
    #endregion

    #region ComplexObjectState Class
    #if (!OPCUA_EXCLUDE_ComplexObjectState)
    /// <summary>
    /// Stores an instance of the ComplexObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ComplexObjectState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ComplexObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ObjectTypeTest.ObjectTypes.ComplexObjectType, ObjectTypeTest.Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAADQAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIvVW5pdFRlc3RzL09iamVjdFR5cGVUZXN0" +
           "/////wRggAABAAAAAQAZAAAAQ29tcGxleE9iamVjdFR5cGVJbnN0YW5jZQEBAQABAQEA/////wMAAAAV" +
           "YMkKAgAAABEAAABCcm93c2VOYW1lNG5vZGU2NgEADQAAAENoaWxkUHJvcGVydHkBAQMAAC4ARAMAAAAA" +
           "Ff////8BAf////8AAAAAFWCJCgIAAAABAA0AAABDaGlsZFZhcmlhYmxlAQErAAAvAQBACSsAAAAAGv//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEvAAAuAEQvAAAAAQB0A/////8BAf////8A" +
           "AAAABGGCCgQAAAABAAsAAABDaGlsZE1ldGhvZAEBCgAALwEBCgAKAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the ChildProperty Property.
        /// </summary>
        public PropertyState<LocalizedText> BrowseName4node66
        {
            get
            {
                return m_browseName4node66;
            }

            set
            {
                if (!Object.ReferenceEquals(m_browseName4node66, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_browseName4node66 = value;
            }
        }

        /// <summary>
        /// A description for the ChildVariable Variable.
        /// </summary>
        public AnalogItemState ChildVariable
        {
            get
            {
                return m_childVariable;
            }

            set
            {
                if (!Object.ReferenceEquals(m_childVariable, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_childVariable = value;
            }
        }

        /// <summary>
        /// A description for the ChildMethod Method.
        /// </summary>
        public ChildMethodMethodState ChildMethod
        {
            get
            {
                return m_childMethodMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_childMethodMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_childMethodMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_browseName4node66 != null)
            {
                children.Add(m_browseName4node66);
            }

            if (m_childVariable != null)
            {
                children.Add(m_childVariable);
            }

            if (m_childMethodMethod != null)
            {
                children.Add(m_childMethodMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case ObjectTypeTest.BrowseNames.BrowseName4node66:
                {
                    if (createOrReplace)
                    {
                        if (BrowseName4node66 == null)
                        {
                            if (replacement == null)
                            {
                                BrowseName4node66 = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                BrowseName4node66 = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = BrowseName4node66;
                    break;
                }

                case ObjectTypeTest.BrowseNames.ChildVariable:
                {
                    if (createOrReplace)
                    {
                        if (ChildVariable == null)
                        {
                            if (replacement == null)
                            {
                                ChildVariable = new AnalogItemState(this);
                            }
                            else
                            {
                                ChildVariable = (AnalogItemState)replacement;
                            }
                        }
                    }

                    instance = ChildVariable;
                    break;
                }

                case ObjectTypeTest.BrowseNames.ChildMethod:
                {
                    if (createOrReplace)
                    {
                        if (ChildMethod == null)
                        {
                            if (replacement == null)
                            {
                                ChildMethod = new ChildMethodMethodState(this);
                            }
                            else
                            {
                                ChildMethod = (ChildMethodMethodState)replacement;
                            }
                        }
                    }

                    instance = ChildMethod;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocalizedText> m_browseName4node66;
        private AnalogItemState m_childVariable;
        private ChildMethodMethodState m_childMethodMethod;
        #endregion
    }
    #endif
    #endregion

    #region DerivedFromComplexObjectState Class
    #if (!OPCUA_EXCLUDE_DerivedFromComplexObjectState)
    /// <summary>
    /// Stores an instance of the DerivedFromComplexObjectType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DerivedFromComplexObjectState : ComplexObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DerivedFromComplexObjectState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ObjectTypeTest.ObjectTypes.DerivedFromComplexObjectType, ObjectTypeTest.Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAADQAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIvVW5pdFRlc3RzL09iamVjdFR5cGVUZXN0" +
           "/////wRggAABAAAAAQAkAAAARGVyaXZlZEZyb21Db21wbGV4T2JqZWN0VHlwZUluc3RhbmNlAQEQAAEB" +
           "EAD/////AwAAABVgyQoCAAAAEQAAAEJyb3dzZU5hbWU0bm9kZTY2AQANAAAAQ2hpbGRQcm9wZXJ0eQEB" +
           "EgAALgBEEgAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAENoaWxkVmFyaWFibGUBATEAAC8B" +
           "AEAJMQAAAAAa/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBATUAAC4ARDUAAAABAHQD" +
           "/////wEB/////wAAAABEYYIKBAAAAAEACwAAAENoaWxkTWV0aG9kAQEZAAMAAAAAEgAAAENoaWxkTWV0" +
           "aG9kTmV3TmFtZQAvAQEKABkAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}