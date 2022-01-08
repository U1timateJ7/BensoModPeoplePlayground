using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.IO;

namespace BensoMod
{
    public class Mod : MonoBehaviour
    {
        public static string ModTag = " [BM]";

        public static void Main()
        {
            CategoryBuilder.Create("BensoMod", "p", ModAPI.LoadSprite("sprites/bensomod.png"));

            #region People
            Texture2D mcFlesh = ModAPI.LoadTexture("sprites/People/mcFlesh.png");
            Texture2D mcBones = ModAPI.LoadTexture("sprites/People/mcBones.png");

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "The Flash" + ModTag,
                DescriptionOverride = "The fastest man alive.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b0",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/flashThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/flash.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/flash.png"), true, "Mask On", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/flashMaskless.png"), true, "Mask Off", ModAPI.LoadSprite("sprites/People/flashHair.png"));
                    }
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Reverse Flash" + ModTag,
                DescriptionOverride = "The ACTUAL fastest man alive.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b1",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/reverseFlashThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/reverseFlash.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/empty.png");
                    childSprite.sortingLayerName = "Top";

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/reverseFlash.png"), true, "Mask On", ModAPI.LoadSprite("sprites/empty.png"));
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/reverseFlashMaskless.png"), true, "Mask Off", ModAPI.LoadSprite("sprites/People/reverseFlashHair.png"));
                    }
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Bruce" + ModTag,
                DescriptionOverride = "Batman but cooler.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b2",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/bruceThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/bruce.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/People/bruceHelmet.png");
                    childSprite.sortingLayerName = "Top";
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Robert" + ModTag,
                DescriptionOverride = "I hate this video game character.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b3",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/robertThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/robert.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/People/robertHair.png");
                    childSprite.sortingLayerName = "Top";
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "TommyInnit" + ModTag,
                DescriptionOverride = "Some people find me annoying first.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b4",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/tommyInnitThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/tommyInnit.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "WilburSoot" + ModTag,
                DescriptionOverride = "Don't say that I will cry.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b5",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/wilburSootThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/wilburSoot.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Ph1LzA" + ModTag,
                DescriptionOverride = "Hardcore expert.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b6",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/ph1lzaThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/ph1lza.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/People/ph1lzaHat.png");
                    childSprite.sortingLayerName = "Top";
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "TechnoBlade" + ModTag,
                DescriptionOverride = "Blood for the blood god.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b7",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/technoThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/techno.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/People/technoCrown.png");
                    childSprite.sortingLayerName = "Top";
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "jschlatt" + ModTag,
                DescriptionOverride = "King Kong Balls.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b8",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/jschlattThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/jschlatt.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Quackity" + ModTag,
                DescriptionOverride = "The plan is simple.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b9",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/quackityThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/quackity.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);

                    var person = Instance.GetComponent<PersonBehaviour>();
                    foreach (var body in person.Limbs)
                    {
                        body.gameObject.AddComponent<CycleSkinTextures>();
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/quackity.png"), "Normal");
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/quackityNaked.png"), "Naked");
                        body.gameObject.GetComponent<CycleSkinTextures>().AddNewTexture(ModAPI.LoadTexture("sprites/People/mexicanDream.png"), "Mexican Dream");
                    }
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "DanTDM" + ModTag,
                DescriptionOverride = "Hello everybody! It's Dan here from The Diamond Minecart.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b9-0",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/dantdmThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/dantdm.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);

                    var head = Instance.transform.GetChild(5);
                    var childObject = new GameObject("Hair");
                    childObject.transform.SetParent(head);
                    childObject.transform.localPosition = new Vector3(0, -0.0275f);
                    childObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    childObject.transform.localScale = new Vector3(1f, 1f);
                    var childSprite = childObject.AddComponent<SpriteRenderer>();
                    childSprite.sprite = ModAPI.LoadSprite("sprites/People/dantdmGoggles.png");
                    childSprite.sortingLayerName = "Top";
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Slimecicle" + ModTag,
                DescriptionOverride = "I'm bones.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b9-1",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/slimecicleThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/slimecicle.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);
                }
            });

            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Human"),
                NameOverride = "Tubbo" + ModTag,
                DescriptionOverride = "I like balls.",
                CategoryOverride = ModAPI.FindCategory("BensoMod"),
                NameToOrderByOverride = "b9-2",
                ThumbnailOverride = ModAPI.LoadSprite("sprites/Thumbnails/tubboThumbnail.png"),
                AfterSpawn = (Instance) =>
                {
                    var skin = ModAPI.LoadTexture("sprites/People/tubbo.png");
                    Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, mcFlesh, mcBones);
                }
            });

            #endregion
        }
    }
    public class CycleSkinTextures : MonoBehaviour
    {
        public class Skin
        {
            public Texture2D SkinTexture;
            public string Description;
            public Texture2D secondTexture;
            public string[] SecondTextureLimbs;
            public bool includesHair;
            public bool glow;
            public Sprite hair;
        }
        public List<Skin> Textures = new List<Skin>();
        int CurrentIndex = 0;
        public PersonBehaviour person;
        public bool CanSwitch = true;
        GameObject SelectedSkin;
        ContextMenuButton menuButton;
        public void Start()
        {
            if (GetComponent<LimbBehaviour>() && !person)
                person = GetComponent<LimbBehaviour>().Person;
            GetComponent<PhysicalBehaviour>().ContextMenuOptions.Buttons.Add(menuButton = new ContextMenuButton("ChangeSkin", "Change Skin", "Change Skin", new UnityAction[1]
            {
                () =>
                {
                    GameObject Canvas = OtherStuff.CreateCanvas();
        if (Canvas)
        {
            GameObject panel = new GameObject("Panel");
            panel.AddComponent<CanvasRenderer>();
            Image i = panel.AddComponent<Image>();
            i.color = new Color(0, 0, 0, 0.8f);
            panel.transform.SetParent(Canvas.transform, false);
            panel.transform.localScale *= 7;
            GameObject Button = new GameObject();
            Button.AddComponent<CanvasRenderer>();
            Image B1I = Button.AddComponent<Image>();
            Button.AddComponent<Button>();
            B1I.color = new Color(0, 0, 0, 0.8f);
            Button.transform.SetParent(panel.transform, false);
            Button.GetComponent<RectTransform>().sizeDelta = new Vector2(36.44165f, 8.680367f);
            Button.GetComponent<RectTransform>().localPosition = new Vector3(-20.9f, -43.5f, 0);
            Button.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            Button.AddComponent<Button>();
            GameObject ButtonText = new GameObject();
            ButtonText.AddComponent<TextMeshProUGUI>().text = "Confirm";
            ButtonText.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            ButtonText.GetComponent<TextMeshProUGUI>().fontSize = 6.7f;
            ButtonText.GetComponent<RectTransform>().sizeDelta = Button.GetComponent<RectTransform>().sizeDelta;
            ButtonText.transform.SetParent(Button.transform, false);
            GameObject Button2 = new GameObject();
            Button2.AddComponent<CanvasRenderer>();
            Image B2I = Button2.AddComponent<Image>();
            Button2.AddComponent<Button>();
            B2I.color = new Color(0, 0, 0, 0.8f);
            Button2.transform.SetParent(panel.transform, false);
            Button2.GetComponent<RectTransform>().sizeDelta = new Vector2(36.44165f, 8.680367f);
            Button2.GetComponent<RectTransform>().localPosition = new Vector3(20.9f, -43.5f, 0);
            Button2.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            Button2.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            Button2.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            Button2.AddComponent<Button>();
            GameObject Button2Text = new GameObject();
            Button2Text.AddComponent<TextMeshProUGUI>().text = "Cancel";
            Button2Text.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Button2Text.GetComponent<TextMeshProUGUI>().fontSize = 6.7f;
            Button2Text.GetComponent<RectTransform>().sizeDelta = Button2.GetComponent<RectTransform>().sizeDelta;
            Button2Text.transform.SetParent(Button2.transform, false);
            GameObject Title = new GameObject();
            Title.AddComponent<TextMeshProUGUI>().text = "Skin/Costume Selector";
            Title.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Title.GetComponent<TextMeshProUGUI>().fontSize = 4.88f;
            Title.GetComponent<RectTransform>().sizeDelta = new Vector2(99.99997f, 12.39016f);
            Title.transform.SetParent(panel.transform, false);
            Title.GetComponent<RectTransform>().localPosition = new Vector3(0, 43.805f, 0);
            GameObject Description = new GameObject();
            Description.AddComponent<TextMeshProUGUI>().text = "";
            Description.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Description.GetComponent<TextMeshProUGUI>().fontSize = 3.13f;
            Description.GetComponent<RectTransform>().sizeDelta = new Vector2(93.73767f, 7.775314f);
            Description.transform.SetParent(panel.transform, false);
            Description.GetComponent<RectTransform>().localPosition = new Vector3(0, -34.7f, 0);
            GameObject AppViewPort = new GameObject("SkinList");
            AppViewPort.AddComponent<CanvasRenderer>();
            Image i5 = AppViewPort.AddComponent<Image>();
            i5.color = new Color(0, 0, 0, 0.3f);
            AppViewPort.AddComponent<Mask>().showMaskGraphic = true;
            AppViewPort.transform.SetParent(Canvas.transform, false);
            AppViewPort.GetComponent<RectTransform>().sizeDelta = new Vector2(638.9575f, 456.4362f);
            AppViewPort.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 45.44891f);
            GameObject SkinList = new GameObject("SkinList");
            SkinList.AddComponent<CanvasRenderer>();
            SkinList.transform.SetParent(AppViewPort.transform, false);
            SkinList.transform.localScale *= 5;
            SkinList.transform.localScale += new Vector3(1.4f, 0, 0);
            SkinList.transform.position += new Vector3(0, 35, 0);
            SkinList.AddComponent<GridLayoutGroup>();
            SkinList.GetComponent<GridLayoutGroup>().padding.top = 3;
            SkinList.GetComponent<GridLayoutGroup>().padding.left = 3;
            SkinList.GetComponent<GridLayoutGroup>().padding.right = 3;
            SkinList.GetComponent<GridLayoutGroup>().cellSize = new Vector2(9, 45);
            SkinList.GetComponent<GridLayoutGroup>().spacing = new Vector2(1.5f, 1.8f);
            SkinList.AddComponent<ContentSizeFitter>().verticalFit = ContentSizeFitter.FitMode.PreferredSize;

            Button.GetComponent<Button>().onClick.AddListener(Select);
            void Select()
            {
                if (SelectedSkin)
                {
                    person.SetBodyTextures(Textures[SelectedSkin.transform.GetSiblingIndex()].SkinTexture);
                    if (Textures[SelectedSkin.transform.GetSiblingIndex()].includesHair)
                    {
                        person.transform.GetChild(person.Limbs[0].SpeciesIdentity == "Android" ? 0 : 5).GetChild(0).GetComponent<SpriteRenderer>().sprite = Textures[SelectedSkin.transform.GetSiblingIndex()].hair;
                    }
                    if (Textures[SelectedSkin.transform.GetSiblingIndex()].secondTexture)
                    {

                        foreach (var body in person.Limbs)
                        {
                            foreach (var item in Textures[SelectedSkin.transform.GetSiblingIndex()].SecondTextureLimbs)
                            {
                                if (body.gameObject.name == item)
                                {
                                    OtherStuff.SetBodyPartTexture(body, Textures[SelectedSkin.transform.GetSiblingIndex()].secondTexture);
                                }
                            }
                        }
                    }
                    Destroy(panel.gameObject);
                    Destroy(SkinList);
                    Destroy(Canvas.gameObject);
                    GameObject.FindObjectOfType<Global>().RemoveUiBlocker();
                }
            }

            Button2.GetComponent<Button>().onClick.AddListener(Cancel);
            void Cancel()
            {
                Destroy(panel.gameObject);
                Destroy(SkinList);
                Destroy(Canvas.gameObject);
                GameObject.FindObjectOfType<Global>().RemoveUiBlocker();
            }

            GameObject Scrollbar = UiCreatingStuff.CreateScrollBar(panel, new Vector2(52.8f, 0.1f));
            Scrollbar.transform.localScale = Scrollbar.transform.localScale * 0.22515f;
            Scrollbar.GetComponent<Scrollbar>().SetDirection(UnityEngine.UI.Scrollbar.Direction.BottomToTop, true);

            SkinList.AddComponent<ScrollRect>();
            SkinList.GetComponent<ScrollRect>().viewport = AppViewPort.GetComponent<RectTransform>();
            SkinList.GetComponent<ScrollRect>().content = SkinList.GetComponent<RectTransform>();
            SkinList.GetComponent<ScrollRect>().scrollSensitivity = 22;

            SkinList.GetComponent<ScrollRect>().horizontal = false;
            SkinList.GetComponent<ScrollRect>().verticalScrollbar = Scrollbar.GetComponent<Scrollbar>();
            SkinList.GetComponent<ScrollRect>().verticalScrollbarSpacing = -3f;

            foreach (var item in Textures)
            {


                GameObject NewSkin = new GameObject("NewSkin");
                NewSkin.AddComponent<CanvasRenderer>();
                Image i3 = NewSkin.AddComponent<Image>();
                i3.color = new Color(0, 0, 0, 0.8f);
                Button SkinButton = NewSkin.AddComponent<Button>();
                SkinButton.GetComponent<Button>().onClick.AddListener(SelectSkin);
                void SelectSkin()
                {
                    if (SelectedSkin)
                        SelectedSkin.GetComponent<Image>().color = new Color(0, 0, 0, 0.4f);
                    SelectedSkin = NewSkin;
                    Description.GetComponent<TextMeshProUGUI>().text = Textures[SelectedSkin.transform.GetSiblingIndex()].Description;
                    SelectedSkin.GetComponent<Image>().color = new Color(1, 1, 1, 0.4f);
                }

                NewSkin.transform.SetParent(SkinList.transform, false);
                GameObject SkinSprite = Instantiate(NewSkin.gameObject, NewSkin.transform);

                Rect rec = new Rect(0, 0, item.SkinTexture.width, item.SkinTexture.height);


                SkinSprite.GetComponent<Image>().sprite = Sprite.Create(item.SkinTexture, rec, new Vector2(0, 0), .01f);
                SkinSprite.GetComponent<Image>().raycastTarget = false;
                SkinSprite.GetComponent<Image>().color = Color.white;
                NewSkin.AddComponent<GridLayoutGroup>().cellSize = new Vector2(9, 45);

            }





        }
                }
                 }));
        }

        public void AddNewTexture(Texture2D texture, string Description = null, Texture2D secondTexture = null, string[] SecondTextureLimbs = null)
        {
            Skin NewSkin = new Skin();
            NewSkin.SkinTexture = texture;
            if (Description != null)
                NewSkin.Description = Description;
            if (secondTexture)
                NewSkin.secondTexture = secondTexture;
            if (SecondTextureLimbs != null)
                NewSkin.SecondTextureLimbs = SecondTextureLimbs;
            Textures.Add(NewSkin);
        }

        public void AddNewTexture(Texture2D texture, bool hasHair, string Description = null, Sprite hair = null)
        {
            Skin NewSkin = new Skin();
            NewSkin.SkinTexture = texture;
            if (Description != null)
                NewSkin.Description = Description;
            NewSkin.includesHair = hasHair;
            if (hair != null)
                NewSkin.hair = hair;
            Textures.Add(NewSkin);
        }

        public void AddNewTexture(Texture2D texture, Texture2D secondTexture, string[] SecondTextureLimbs, bool hasHair, string Description = null, Sprite hair = null)
        {
            Skin NewSkin = new Skin();
            NewSkin.SkinTexture = texture;
            if (Description != null)
                NewSkin.Description = Description;
            if (secondTexture)
                NewSkin.secondTexture = secondTexture;
            if (SecondTextureLimbs != null)
                NewSkin.SecondTextureLimbs = SecondTextureLimbs;
            NewSkin.includesHair = hasHair;
            if (hair != null)
                NewSkin.hair = hair;
            Textures.Add(NewSkin);
        }
    }

    public class OtherStuff : MonoBehaviour
    {
        public static void SetBodyPartTexture(LimbBehaviour body, Texture2D Skin, Texture2D Flesh = null)
        {
            float scale = 1f;
            SpriteRenderer renderer = body.SkinMaterialHandler.renderer;
            Sprite sprite1 = renderer.sprite;
            Sprite sprite2 = generateFor(Skin, sprite1);
            renderer.sprite = sprite2;
            if (Flesh)
                renderer.material.SetTexture("_FleshTex", Flesh);



            Sprite generateFor(Texture2D t, Sprite original)
            {
                Texture2D texture = t;
                Rect rect1 = original.rect;
                Vector2 position = rect1.position * scale;
                rect1 = original.rect;
                Vector2 size = rect1.size * scale;
                Rect rect2 = new Rect(position, size);
                Vector2 pivot = new Vector2(0.5f, 0.5f);
                double num = original.pixelsPerUnit * (double)scale;
                Vector4 border = original.border * scale;
                return Sprite.Create(texture, rect2, pivot, (float)num, 0U, SpriteMeshType.FullRect, border, false);

            }
        }

        public static void RemakeBodyPartNew(LimbBehaviour body, string Path)
        {
            string PartName = body.gameObject.name;
            if (PartName.Contains("Front"))
            {
                PartName = PartName.Remove(PartName.LastIndexOf("Front"), 5);
            }


            body.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite($"{Path}{PartName}.png");
            body.GetComponent<SpriteRenderer>().material.SetTexture("_FleshTex", ModAPI.LoadTexture($"{Path}{PartName} F.png"));
            body.GetComponent<SpriteRenderer>().material.SetTexture("_BoneTex", ModAPI.LoadTexture($"{Path}{PartName} B.png"));
        }

        public static GameObject CreateCanvas(bool AddUiBlocker = true, bool AddGreyBgg = true)
        {
            if (!FindObjectOfType<CanvasTag>())
            {
                if (AddUiBlocker)
                    GameObject.FindObjectOfType<Global>().AddUiBlocker();
                GameObject Canvas = new GameObject();
                GameObject GreyBg;
                if (AddGreyBgg)
                {
                    GreyBg = UiCreatingStuff.CreatePanel(Canvas, new Vector2(55500, 55500), Vector2.zero, 0.7f);
                    GreyBg.GetComponent<Image>().color = new Color(0.2075472f, 0.2075472f, 0.2075472f, 0.5450981f);
                    Canvas.AddComponent<CanvasTag>().Bg = GreyBg;
                }
                Canvas.AddComponent<Canvas>();
                Canvas.AddComponent<CanvasScaler>();
                Canvas.AddComponent<GraphicRaycaster>();
                Canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
                Canvas.GetComponent<Canvas>().sortingOrder = -2;
                Canvas.GetComponent<CanvasScaler>().uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                Canvas.GetComponent<CanvasScaler>().referenceResolution = new Vector2(1920, 1080);
                Canvas.GetComponent<CanvasScaler>().screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
                Canvas.GetComponent<CanvasScaler>().matchWidthOrHeight = 0.763f;
                return Canvas;
            }
            else return null;
        }

        public class CanvasTag : MonoBehaviour
        {
            public GameObject Bg;

            public void OnDestroy()
            {
                if (FindObjectOfType<Global>().ActiveUiBlockers > 0)
                    FindObjectOfType<Global>().RemoveUiBlocker();

                if (Bg)
                    Destroy(Bg);
            }
        }
    }

    public class UiCreatingStuff : MonoBehaviour
    {
        public static GameObject CreateButton(GameObject ParentOrCanvas, string ButtonText, Vector3 Position, Vector2 SizeDelta, float TextSize = 6.7f)
        {
            if (SizeDelta == Vector2.zero) SizeDelta = new Vector2(36.44165f, 8.680367f);
            GameObject Button = new GameObject();
            Button.AddComponent<CanvasRenderer>();
            Image B1I = Button.AddComponent<Image>();
            Button.AddComponent<Button>();
            B1I.color = new Color(0, 0, 0, 0.8f);
            Button.transform.SetParent(ParentOrCanvas.transform, false);
            Button.GetComponent<RectTransform>().sizeDelta = SizeDelta;
            Button.GetComponent<RectTransform>().localPosition = Position;
            Button.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
            Button.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            Button.AddComponent<AudioSource>();
            GameObject ButtonTextObject = new GameObject();
            ButtonTextObject.AddComponent<TextMeshProUGUI>().text = ButtonText;
            ButtonTextObject.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            ButtonTextObject.GetComponent<TextMeshProUGUI>().fontSize = TextSize;
            ButtonTextObject.GetComponent<TextMeshProUGUI>().fontSizeMin = 0;
            ButtonTextObject.transform.SetParent(Button.transform, false);
            ButtonTextObject.GetComponent<RectTransform>().sizeDelta = Button.GetComponent<RectTransform>().sizeDelta;
            return Button;
        }

        public static GameObject CreateText(GameObject ParentOrCanvas, string Text, Vector3 Position, Vector2 SizeDelta, float TextSize = 5.4f)
        {
            if (SizeDelta == Vector2.zero) SizeDelta = new Vector2(99.99997f, 12.39016f);
            GameObject Title = new GameObject();
            Title.AddComponent<TextMeshProUGUI>().text = Text;
            Title.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
            Title.GetComponent<TextMeshProUGUI>().fontSize = TextSize;
            Title.GetComponent<RectTransform>().sizeDelta = SizeDelta;
            Title.transform.SetParent(ParentOrCanvas.transform, false);
            Title.GetComponent<RectTransform>().localPosition = Position;
            return Title;
        }

        public static GameObject CreatePanel(GameObject ParentOrCanvas, Vector2 SizeDelta, Vector3 Postion, float Opacity = 0.4f)
        {
            GameObject Panel = new GameObject("Panel");
            Panel.AddComponent<CanvasRenderer>();
            Image AppImage = Panel.AddComponent<Image>();
            AppImage.color = new Color(0, 0, 0, Opacity);
            Panel.transform.SetParent(ParentOrCanvas.transform, false);
            Panel.GetComponent<RectTransform>().sizeDelta = SizeDelta;
            Panel.GetComponent<RectTransform>().localPosition = Postion;
            return Panel;
        }

        public static GameObject CreateScrollBar(GameObject ParentOrCanvas, Vector2 Position)
        {
            GameObject Scrollbar = CreatePanel(ParentOrCanvas, new Vector2(160f, 20f), new Vector3(0, 0, 0));
            Scrollbar.AddComponent<Scrollbar>();
            GameObject SlidingArea = new GameObject();
            SlidingArea.AddComponent<RectTransform>();
            SlidingArea.GetComponent<RectTransform>().offsetMax = new Vector2(-10, -10);
            SlidingArea.GetComponent<RectTransform>().offsetMin = new Vector2(10, 10);
            SlidingArea.GetComponent<RectTransform>().anchorMin = Vector2.zero;
            SlidingArea.GetComponent<RectTransform>().anchorMax = Vector2.one;
            SlidingArea.transform.SetParent(Scrollbar.transform, false);
            GameObject HandelBar = CreatePanel(SlidingArea, new Vector2(160f, 20f), new Vector3(0, 0, 0));
            HandelBar.GetComponent<RectTransform>().offsetMax = new Vector2(10, 10);
            HandelBar.GetComponent<RectTransform>().offsetMin = new Vector2(-10, -10);
            Scrollbar.GetComponent<Scrollbar>().handleRect = HandelBar.GetComponent<RectTransform>();
            Scrollbar.GetComponent<Scrollbar>().targetGraphic = HandelBar.GetComponent<Image>();
            Scrollbar.GetComponent<RectTransform>().localPosition = Position;
            return Scrollbar;
        }
    }
}