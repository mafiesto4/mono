//------------------------------------------------------------------------------
// <copyright file="IContainer.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace System.ComponentModel {

    /*
     * A "container" is an object that logically contains zero or more child
     * components.
     *
     * In this context, "containment" refers to logical containment, not visual
     * containment.  Components and containers can be used in a variety of
     * scenarios, including both visual and non-visual scenarios.
     */
    // Interfaces don't need to be serializable
    /// <devdoc>
    ///    <para>Provides
    ///       functionality for containers. Containers are objects that logically contain zero or more components.</para>
    /// </devdoc>
    [System.Runtime.InteropServices.ComVisible(true)]
    public interface IContainer : IDisposable {

        // Adds a component to the container.
        /// <devdoc>
        /// <para>Adds the specified <see cref='System.ComponentModel.IComponent'/> to the <see cref='System.ComponentModel.IContainer'/>
        /// at the end of the list.</para>
        /// </devdoc>
        void Add(IComponent component);

        //  Adds a component to the container.
        /// <devdoc>
        /// <para>Adds the specified <see cref='System.ComponentModel.IComponent'/> to the <see cref='System.ComponentModel.IContainer'/>
        /// at the end of the list, and assigns a name to the component.</para>
        /// </devdoc>
        void Add(IComponent component, String name);

        // The components in the container.
        /// <devdoc>
        /// <para>Gets all the components in the <see cref='System.ComponentModel.IContainer'/>.</para>
        /// </devdoc>
        ComponentCollection Components {get;}

        // Removes a component from the container.
        /// <devdoc>
        /// <para>Removes a component from the <see cref='System.ComponentModel.IContainer'/>.</para>
        /// </devdoc>
        void Remove(IComponent component);
    }
}
