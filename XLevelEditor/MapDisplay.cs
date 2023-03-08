using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLevelEditor
{
    public class AbstractControlDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {
        public AbstractControlDescriptionProvider()
            : base(TypeDescriptor.GetProvider(typeof(TAbstract)))
        {
        }

        public override Type GetReflectionType(Type objectType, object instance)
        {
            if (objectType == typeof(TAbstract))
                return typeof(TBase);

            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            if (objectType == typeof(TAbstract))
                objectType = typeof(TBase);

            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }


    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AbstractControl, MonoGameControl>))]
    public abstract class AbstractControl : MonoGameControl
    {

    }

    public class MapDisplay : AbstractControl
    {
        protected override void Initialize()
        {
            base.Initialize();

        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw()
        {
            base.Draw();

            if (FormMain.map == null)
                return;

            Editor.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp,
                null, null, null, FormMain.camera.Transformation);

            for (int i = 0; i < FormMain.layers.Count; i++)
                FormMain.layers[i].Draw(Editor.spriteBatch, FormMain.camera, FormMain.tileSets);

            Editor.spriteBatch.End();
        }

    }
}
