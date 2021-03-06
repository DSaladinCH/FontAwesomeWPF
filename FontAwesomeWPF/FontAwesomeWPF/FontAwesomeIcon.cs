﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DSaladin.FontAwesomeWPF
{
    public enum FontAwesomeIcon
    {
        ///<summary>Set this value to show no icon.</summary>
        [Description("None"), IconID("none")]
        None = 0x0,
        ///<summary>Brands 500Px</summary>
        ///<see href="https://fontawesome.com/icons/500px?style=brands"/>
        [Description("Brands 500Px"), IconID("fab-500px")]
        Brands500Px = 0xf26e,
        ///<summary>Brands Accessible Icon</summary>
        ///<see href="https://fontawesome.com/icons/accessible-icon?style=brands"/>
        [Description("Brands Accessible Icon"), IconID("fab-accessible-icon")]
        BrandsAccessibleIcon = 0xf368,
        ///<summary>Brands Accusoft</summary>
        ///<see href="https://fontawesome.com/icons/accusoft?style=brands"/>
        [Description("Brands Accusoft"), IconID("fab-accusoft")]
        BrandsAccusoft = 0xf369,
        ///<summary>Brands Acquisitions Incorporated</summary>
        ///<see href="https://fontawesome.com/icons/acquisitions-incorporated?style=brands"/>
        [Description("Brands Acquisitions Incorporated"), IconID("fab-acquisitions-incorporated")]
        BrandsAcquisitionsIncorporated = 0xf6af,
        ///<summary>Brands Adn</summary>
        ///<see href="https://fontawesome.com/icons/adn?style=brands"/>
        [Description("Brands Adn"), IconID("fab-adn")]
        BrandsAdn = 0xf170,
        ///<summary>Brands Adversal</summary>
        ///<see href="https://fontawesome.com/icons/adversal?style=brands"/>
        [Description("Brands Adversal"), IconID("fab-adversal")]
        BrandsAdversal = 0xf36a,
        ///<summary>Brands Affiliatetheme</summary>
        ///<see href="https://fontawesome.com/icons/affiliatetheme?style=brands"/>
        [Description("Brands Affiliatetheme"), IconID("fab-affiliatetheme")]
        BrandsAffiliatetheme = 0xf36b,
        ///<summary>Brands Airbnb</summary>
        ///<see href="https://fontawesome.com/icons/airbnb?style=brands"/>
        [Description("Brands Airbnb"), IconID("fab-airbnb")]
        BrandsAirbnb = 0xf834,
        ///<summary>Brands Algolia</summary>
        ///<see href="https://fontawesome.com/icons/algolia?style=brands"/>
        [Description("Brands Algolia"), IconID("fab-algolia")]
        BrandsAlgolia = 0xf36c,
        ///<summary>Brands Alipay</summary>
        ///<see href="https://fontawesome.com/icons/alipay?style=brands"/>
        [Description("Brands Alipay"), IconID("fab-alipay")]
        BrandsAlipay = 0xf642,
        ///<summary>Brands Amazon</summary>
        ///<see href="https://fontawesome.com/icons/amazon?style=brands"/>
        [Description("Brands Amazon"), IconID("fab-amazon")]
        BrandsAmazon = 0xf270,
        ///<summary>Brands Amazon Pay</summary>
        ///<see href="https://fontawesome.com/icons/amazon-pay?style=brands"/>
        [Description("Brands Amazon Pay"), IconID("fab-amazon-pay")]
        BrandsAmazonPay = 0xf42c,
        ///<summary>Brands Amilia</summary>
        ///<see href="https://fontawesome.com/icons/amilia?style=brands"/>
        [Description("Brands Amilia"), IconID("fab-amilia")]
        BrandsAmilia = 0xf36d,
        ///<summary>Brands Android</summary>
        ///<see href="https://fontawesome.com/icons/android?style=brands"/>
        [Description("Brands Android"), IconID("fab-android")]
        BrandsAndroid = 0xf17b,
        ///<summary>Brands Angellist</summary>
        ///<see href="https://fontawesome.com/icons/angellist?style=brands"/>
        [Description("Brands Angellist"), IconID("fab-angellist")]
        BrandsAngellist = 0xf209,
        ///<summary>Brands Angrycreative</summary>
        ///<see href="https://fontawesome.com/icons/angrycreative?style=brands"/>
        [Description("Brands Angrycreative"), IconID("fab-angrycreative")]
        BrandsAngrycreative = 0xf36e,
        ///<summary>Brands Angular</summary>
        ///<see href="https://fontawesome.com/icons/angular?style=brands"/>
        [Description("Brands Angular"), IconID("fab-angular")]
        BrandsAngular = 0xf420,
        ///<summary>Brands App Store</summary>
        ///<see href="https://fontawesome.com/icons/app-store?style=brands"/>
        [Description("Brands App Store"), IconID("fab-app-store")]
        BrandsAppStore = 0xf36f,
        ///<summary>Brands App Store Ios</summary>
        ///<see href="https://fontawesome.com/icons/app-store-ios?style=brands"/>
        [Description("Brands App Store Ios"), IconID("fab-app-store-ios")]
        BrandsAppStoreIos = 0xf370,
        ///<summary>Brands Apper</summary>
        ///<see href="https://fontawesome.com/icons/apper?style=brands"/>
        [Description("Brands Apper"), IconID("fab-apper")]
        BrandsApper = 0xf371,
        ///<summary>Brands Apple</summary>
        ///<see href="https://fontawesome.com/icons/apple?style=brands"/>
        [Description("Brands Apple"), IconID("fab-apple")]
        BrandsApple = 0xf179,
        ///<summary>Brands Apple Pay</summary>
        ///<see href="https://fontawesome.com/icons/apple-pay?style=brands"/>
        [Description("Brands Apple Pay"), IconID("fab-apple-pay")]
        BrandsApplePay = 0xf415,
        ///<summary>Brands Artstation</summary>
        ///<see href="https://fontawesome.com/icons/artstation?style=brands"/>
        [Description("Brands Artstation"), IconID("fab-artstation")]
        BrandsArtstation = 0xf77a,
        ///<summary>Brands Asymmetrik</summary>
        ///<see href="https://fontawesome.com/icons/asymmetrik?style=brands"/>
        [Description("Brands Asymmetrik"), IconID("fab-asymmetrik")]
        BrandsAsymmetrik = 0xf372,
        ///<summary>Brands Atlassian</summary>
        ///<see href="https://fontawesome.com/icons/atlassian?style=brands"/>
        [Description("Brands Atlassian"), IconID("fab-atlassian")]
        BrandsAtlassian = 0xf77b,
        ///<summary>Brands Audible</summary>
        ///<see href="https://fontawesome.com/icons/audible?style=brands"/>
        [Description("Brands Audible"), IconID("fab-audible")]
        BrandsAudible = 0xf373,
        ///<summary>Brands Autoprefixer</summary>
        ///<see href="https://fontawesome.com/icons/autoprefixer?style=brands"/>
        [Description("Brands Autoprefixer"), IconID("fab-autoprefixer")]
        BrandsAutoprefixer = 0xf41c,
        ///<summary>Brands Avianex</summary>
        ///<see href="https://fontawesome.com/icons/avianex?style=brands"/>
        [Description("Brands Avianex"), IconID("fab-avianex")]
        BrandsAvianex = 0xf374,
        ///<summary>Brands Aviato</summary>
        ///<see href="https://fontawesome.com/icons/aviato?style=brands"/>
        [Description("Brands Aviato"), IconID("fab-aviato")]
        BrandsAviato = 0xf421,
        ///<summary>Brands Aws</summary>
        ///<see href="https://fontawesome.com/icons/aws?style=brands"/>
        [Description("Brands Aws"), IconID("fab-aws")]
        BrandsAws = 0xf375,
        ///<summary>Brands Bandcamp</summary>
        ///<see href="https://fontawesome.com/icons/bandcamp?style=brands"/>
        [Description("Brands Bandcamp"), IconID("fab-bandcamp")]
        BrandsBandcamp = 0xf2d5,
        ///<summary>Brands Battle Net</summary>
        ///<see href="https://fontawesome.com/icons/battle-net?style=brands"/>
        [Description("Brands Battle Net"), IconID("fab-battle-net")]
        BrandsBattleNet = 0xf835,
        ///<summary>Brands Behance</summary>
        ///<see href="https://fontawesome.com/icons/behance?style=brands"/>
        [Description("Brands Behance"), IconID("fab-behance")]
        BrandsBehance = 0xf1b4,
        ///<summary>Brands Behance Square</summary>
        ///<see href="https://fontawesome.com/icons/behance-square?style=brands"/>
        [Description("Brands Behance Square"), IconID("fab-behance-square")]
        BrandsBehanceSquare = 0xf1b5,
        ///<summary>Brands Bimobject</summary>
        ///<see href="https://fontawesome.com/icons/bimobject?style=brands"/>
        [Description("Brands Bimobject"), IconID("fab-bimobject")]
        BrandsBimobject = 0xf378,
        ///<summary>Brands Bitbucket</summary>
        ///<see href="https://fontawesome.com/icons/bitbucket?style=brands"/>
        [Description("Brands Bitbucket"), IconID("fab-bitbucket")]
        BrandsBitbucket = 0xf171,
        ///<summary>Brands Bitcoin</summary>
        ///<see href="https://fontawesome.com/icons/bitcoin?style=brands"/>
        [Description("Brands Bitcoin"), IconID("fab-bitcoin")]
        BrandsBitcoin = 0xf379,
        ///<summary>Brands Bity</summary>
        ///<see href="https://fontawesome.com/icons/bity?style=brands"/>
        [Description("Brands Bity"), IconID("fab-bity")]
        BrandsBity = 0xf37a,
        ///<summary>Brands Black Tie</summary>
        ///<see href="https://fontawesome.com/icons/black-tie?style=brands"/>
        [Description("Brands Black Tie"), IconID("fab-black-tie")]
        BrandsBlackTie = 0xf27e,
        ///<summary>Brands Blackberry</summary>
        ///<see href="https://fontawesome.com/icons/blackberry?style=brands"/>
        [Description("Brands Blackberry"), IconID("fab-blackberry")]
        BrandsBlackberry = 0xf37b,
        ///<summary>Brands Blogger</summary>
        ///<see href="https://fontawesome.com/icons/blogger?style=brands"/>
        [Description("Brands Blogger"), IconID("fab-blogger")]
        BrandsBlogger = 0xf37c,
        ///<summary>Brands Blogger B</summary>
        ///<see href="https://fontawesome.com/icons/blogger-b?style=brands"/>
        [Description("Brands Blogger B"), IconID("fab-blogger-b")]
        BrandsBloggerB = 0xf37d,
        ///<summary>Brands Bluetooth</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth?style=brands"/>
        [Description("Brands Bluetooth"), IconID("fab-bluetooth")]
        BrandsBluetooth = 0xf293,
        ///<summary>Brands Bluetooth B</summary>
        ///<see href="https://fontawesome.com/icons/bluetooth-b?style=brands"/>
        [Description("Brands Bluetooth B"), IconID("fab-bluetooth-b")]
        BrandsBluetoothB = 0xf294,
        ///<summary>Brands Bootstrap</summary>
        ///<see href="https://fontawesome.com/icons/bootstrap?style=brands"/>
        [Description("Brands Bootstrap"), IconID("fab-bootstrap")]
        BrandsBootstrap = 0xf836,
        ///<summary>Brands Btc</summary>
        ///<see href="https://fontawesome.com/icons/btc?style=brands"/>
        [Description("Brands Btc"), IconID("fab-btc")]
        BrandsBtc = 0xf15a,
        ///<summary>Brands Buffer</summary>
        ///<see href="https://fontawesome.com/icons/buffer?style=brands"/>
        [Description("Brands Buffer"), IconID("fab-buffer")]
        BrandsBuffer = 0xf837,
        ///<summary>Brands Buromobelexperte</summary>
        ///<see href="https://fontawesome.com/icons/buromobelexperte?style=brands"/>
        [Description("Brands Buromobelexperte"), IconID("fab-buromobelexperte")]
        BrandsBuromobelexperte = 0xf37f,
        ///<summary>Brands Buy N Large</summary>
        ///<see href="https://fontawesome.com/icons/buy-n-large?style=brands"/>
        [Description("Brands Buy N Large"), IconID("fab-buy-n-large")]
        BrandsBuyNLarge = 0xf8a6,
        ///<summary>Brands Buysellads</summary>
        ///<see href="https://fontawesome.com/icons/buysellads?style=brands"/>
        [Description("Brands Buysellads"), IconID("fab-buysellads")]
        BrandsBuysellads = 0xf20d,
        ///<summary>Brands Canadian Maple Leaf</summary>
        ///<see href="https://fontawesome.com/icons/canadian-maple-leaf?style=brands"/>
        [Description("Brands Canadian Maple Leaf"), IconID("fab-canadian-maple-leaf")]
        BrandsCanadianMapleLeaf = 0xf785,
        ///<summary>Brands Cc Amazon Pay</summary>
        ///<see href="https://fontawesome.com/icons/cc-amazon-pay?style=brands"/>
        [Description("Brands Cc Amazon Pay"), IconID("fab-cc-amazon-pay")]
        BrandsCcAmazonPay = 0xf42d,
        ///<summary>Brands Cc Amex</summary>
        ///<see href="https://fontawesome.com/icons/cc-amex?style=brands"/>
        [Description("Brands Cc Amex"), IconID("fab-cc-amex")]
        BrandsCcAmex = 0xf1f3,
        ///<summary>Brands Cc Apple Pay</summary>
        ///<see href="https://fontawesome.com/icons/cc-apple-pay?style=brands"/>
        [Description("Brands Cc Apple Pay"), IconID("fab-cc-apple-pay")]
        BrandsCcApplePay = 0xf416,
        ///<summary>Brands Cc Diners Club</summary>
        ///<see href="https://fontawesome.com/icons/cc-diners-club?style=brands"/>
        [Description("Brands Cc Diners Club"), IconID("fab-cc-diners-club")]
        BrandsCcDinersClub = 0xf24c,
        ///<summary>Brands Cc Discover</summary>
        ///<see href="https://fontawesome.com/icons/cc-discover?style=brands"/>
        [Description("Brands Cc Discover"), IconID("fab-cc-discover")]
        BrandsCcDiscover = 0xf1f2,
        ///<summary>Brands Cc Jcb</summary>
        ///<see href="https://fontawesome.com/icons/cc-jcb?style=brands"/>
        [Description("Brands Cc Jcb"), IconID("fab-cc-jcb")]
        BrandsCcJcb = 0xf24b,
        ///<summary>Brands Cc Mastercard</summary>
        ///<see href="https://fontawesome.com/icons/cc-mastercard?style=brands"/>
        [Description("Brands Cc Mastercard"), IconID("fab-cc-mastercard")]
        BrandsCcMastercard = 0xf1f1,
        ///<summary>Brands Cc Paypal</summary>
        ///<see href="https://fontawesome.com/icons/cc-paypal?style=brands"/>
        [Description("Brands Cc Paypal"), IconID("fab-cc-paypal")]
        BrandsCcPaypal = 0xf1f4,
        ///<summary>Brands Cc Stripe</summary>
        ///<see href="https://fontawesome.com/icons/cc-stripe?style=brands"/>
        [Description("Brands Cc Stripe"), IconID("fab-cc-stripe")]
        BrandsCcStripe = 0xf1f5,
        ///<summary>Brands Cc Visa</summary>
        ///<see href="https://fontawesome.com/icons/cc-visa?style=brands"/>
        [Description("Brands Cc Visa"), IconID("fab-cc-visa")]
        BrandsCcVisa = 0xf1f0,
        ///<summary>Brands Centercode</summary>
        ///<see href="https://fontawesome.com/icons/centercode?style=brands"/>
        [Description("Brands Centercode"), IconID("fab-centercode")]
        BrandsCentercode = 0xf380,
        ///<summary>Brands Centos</summary>
        ///<see href="https://fontawesome.com/icons/centos?style=brands"/>
        [Description("Brands Centos"), IconID("fab-centos")]
        BrandsCentos = 0xf789,
        ///<summary>Brands Chrome</summary>
        ///<see href="https://fontawesome.com/icons/chrome?style=brands"/>
        [Description("Brands Chrome"), IconID("fab-chrome")]
        BrandsChrome = 0xf268,
        ///<summary>Brands Chromecast</summary>
        ///<see href="https://fontawesome.com/icons/chromecast?style=brands"/>
        [Description("Brands Chromecast"), IconID("fab-chromecast")]
        BrandsChromecast = 0xf838,
        ///<summary>Brands Cloudflare</summary>
        ///<see href="https://fontawesome.com/icons/cloudflare?style=brands"/>
        [Description("Brands Cloudflare"), IconID("fab-cloudflare")]
        BrandsCloudflare = 0xe07d,
        ///<summary>Brands Cloudscale</summary>
        ///<see href="https://fontawesome.com/icons/cloudscale?style=brands"/>
        [Description("Brands Cloudscale"), IconID("fab-cloudscale")]
        BrandsCloudscale = 0xf383,
        ///<summary>Brands Cloudsmith</summary>
        ///<see href="https://fontawesome.com/icons/cloudsmith?style=brands"/>
        [Description("Brands Cloudsmith"), IconID("fab-cloudsmith")]
        BrandsCloudsmith = 0xf384,
        ///<summary>Brands Cloudversify</summary>
        ///<see href="https://fontawesome.com/icons/cloudversify?style=brands"/>
        [Description("Brands Cloudversify"), IconID("fab-cloudversify")]
        BrandsCloudversify = 0xf385,
        ///<summary>Brands Codepen</summary>
        ///<see href="https://fontawesome.com/icons/codepen?style=brands"/>
        [Description("Brands Codepen"), IconID("fab-codepen")]
        BrandsCodepen = 0xf1cb,
        ///<summary>Brands Codiepie</summary>
        ///<see href="https://fontawesome.com/icons/codiepie?style=brands"/>
        [Description("Brands Codiepie"), IconID("fab-codiepie")]
        BrandsCodiepie = 0xf284,
        ///<summary>Brands Confluence</summary>
        ///<see href="https://fontawesome.com/icons/confluence?style=brands"/>
        [Description("Brands Confluence"), IconID("fab-confluence")]
        BrandsConfluence = 0xf78d,
        ///<summary>Brands Connectdevelop</summary>
        ///<see href="https://fontawesome.com/icons/connectdevelop?style=brands"/>
        [Description("Brands Connectdevelop"), IconID("fab-connectdevelop")]
        BrandsConnectdevelop = 0xf20e,
        ///<summary>Brands Contao</summary>
        ///<see href="https://fontawesome.com/icons/contao?style=brands"/>
        [Description("Brands Contao"), IconID("fab-contao")]
        BrandsContao = 0xf26d,
        ///<summary>Brands Cotton Bureau</summary>
        ///<see href="https://fontawesome.com/icons/cotton-bureau?style=brands"/>
        [Description("Brands Cotton Bureau"), IconID("fab-cotton-bureau")]
        BrandsCottonBureau = 0xf89e,
        ///<summary>Brands Cpanel</summary>
        ///<see href="https://fontawesome.com/icons/cpanel?style=brands"/>
        [Description("Brands Cpanel"), IconID("fab-cpanel")]
        BrandsCpanel = 0xf388,
        ///<summary>Brands Creative Commons</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons?style=brands"/>
        [Description("Brands Creative Commons"), IconID("fab-creative-commons")]
        BrandsCreativeCommons = 0xf25e,
        ///<summary>Brands Creative Commons By</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-by?style=brands"/>
        [Description("Brands Creative Commons By"), IconID("fab-creative-commons-by")]
        BrandsCreativeCommonsBy = 0xf4e7,
        ///<summary>Brands Creative Commons Nc</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc?style=brands"/>
        [Description("Brands Creative Commons Nc"), IconID("fab-creative-commons-nc")]
        BrandsCreativeCommonsNc = 0xf4e8,
        ///<summary>Brands Creative Commons Nc Eu</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-eu?style=brands"/>
        [Description("Brands Creative Commons Nc Eu"), IconID("fab-creative-commons-nc-eu")]
        BrandsCreativeCommonsNcEu = 0xf4e9,
        ///<summary>Brands Creative Commons Nc Jp</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nc-jp?style=brands"/>
        [Description("Brands Creative Commons Nc Jp"), IconID("fab-creative-commons-nc-jp")]
        BrandsCreativeCommonsNcJp = 0xf4ea,
        ///<summary>Brands Creative Commons Nd</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-nd?style=brands"/>
        [Description("Brands Creative Commons Nd"), IconID("fab-creative-commons-nd")]
        BrandsCreativeCommonsNd = 0xf4eb,
        ///<summary>Brands Creative Commons Pd</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd?style=brands"/>
        [Description("Brands Creative Commons Pd"), IconID("fab-creative-commons-pd")]
        BrandsCreativeCommonsPd = 0xf4ec,
        ///<summary>Brands Creative Commons Pd Alt</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-pd-alt?style=brands"/>
        [Description("Brands Creative Commons Pd Alt"), IconID("fab-creative-commons-pd-alt")]
        BrandsCreativeCommonsPdAlt = 0xf4ed,
        ///<summary>Brands Creative Commons Remix</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-remix?style=brands"/>
        [Description("Brands Creative Commons Remix"), IconID("fab-creative-commons-remix")]
        BrandsCreativeCommonsRemix = 0xf4ee,
        ///<summary>Brands Creative Commons Sa</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sa?style=brands"/>
        [Description("Brands Creative Commons Sa"), IconID("fab-creative-commons-sa")]
        BrandsCreativeCommonsSa = 0xf4ef,
        ///<summary>Brands Creative Commons Sampling</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling?style=brands"/>
        [Description("Brands Creative Commons Sampling"), IconID("fab-creative-commons-sampling")]
        BrandsCreativeCommonsSampling = 0xf4f0,
        ///<summary>Brands Creative Commons Sampling Plus</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-sampling-plus?style=brands"/>
        [Description("Brands Creative Commons Sampling Plus"), IconID("fab-creative-commons-sampling-plus")]
        BrandsCreativeCommonsSamplingPlus = 0xf4f1,
        ///<summary>Brands Creative Commons Share</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-share?style=brands"/>
        [Description("Brands Creative Commons Share"), IconID("fab-creative-commons-share")]
        BrandsCreativeCommonsShare = 0xf4f2,
        ///<summary>Brands Creative Commons Zero</summary>
        ///<see href="https://fontawesome.com/icons/creative-commons-zero?style=brands"/>
        [Description("Brands Creative Commons Zero"), IconID("fab-creative-commons-zero")]
        BrandsCreativeCommonsZero = 0xf4f3,
        ///<summary>Brands Critical Role</summary>
        ///<see href="https://fontawesome.com/icons/critical-role?style=brands"/>
        [Description("Brands Critical Role"), IconID("fab-critical-role")]
        BrandsCriticalRole = 0xf6c9,
        ///<summary>Brands Css3</summary>
        ///<see href="https://fontawesome.com/icons/css3?style=brands"/>
        [Description("Brands Css3"), IconID("fab-css3")]
        BrandsCss3 = 0xf13c,
        ///<summary>Brands Css3 Alt</summary>
        ///<see href="https://fontawesome.com/icons/css3-alt?style=brands"/>
        [Description("Brands Css3 Alt"), IconID("fab-css3-alt")]
        BrandsCss3Alt = 0xf38b,
        ///<summary>Brands Cuttlefish</summary>
        ///<see href="https://fontawesome.com/icons/cuttlefish?style=brands"/>
        [Description("Brands Cuttlefish"), IconID("fab-cuttlefish")]
        BrandsCuttlefish = 0xf38c,
        ///<summary>Brands D And D</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d?style=brands"/>
        [Description("Brands D And D"), IconID("fab-d-and-d")]
        BrandsDAndD = 0xf38d,
        ///<summary>Brands D And D Beyond</summary>
        ///<see href="https://fontawesome.com/icons/d-and-d-beyond?style=brands"/>
        [Description("Brands D And D Beyond"), IconID("fab-d-and-d-beyond")]
        BrandsDAndDBeyond = 0xf6ca,
        ///<summary>Brands Dailymotion</summary>
        ///<see href="https://fontawesome.com/icons/dailymotion?style=brands"/>
        [Description("Brands Dailymotion"), IconID("fab-dailymotion")]
        BrandsDailymotion = 0xe052,
        ///<summary>Brands Dashcube</summary>
        ///<see href="https://fontawesome.com/icons/dashcube?style=brands"/>
        [Description("Brands Dashcube"), IconID("fab-dashcube")]
        BrandsDashcube = 0xf210,
        ///<summary>Brands Deezer</summary>
        ///<see href="https://fontawesome.com/icons/deezer?style=brands"/>
        [Description("Brands Deezer"), IconID("fab-deezer")]
        BrandsDeezer = 0xe077,
        ///<summary>Brands Delicious</summary>
        ///<see href="https://fontawesome.com/icons/delicious?style=brands"/>
        [Description("Brands Delicious"), IconID("fab-delicious")]
        BrandsDelicious = 0xf1a5,
        ///<summary>Brands Deploydog</summary>
        ///<see href="https://fontawesome.com/icons/deploydog?style=brands"/>
        [Description("Brands Deploydog"), IconID("fab-deploydog")]
        BrandsDeploydog = 0xf38e,
        ///<summary>Brands Deskpro</summary>
        ///<see href="https://fontawesome.com/icons/deskpro?style=brands"/>
        [Description("Brands Deskpro"), IconID("fab-deskpro")]
        BrandsDeskpro = 0xf38f,
        ///<summary>Brands Dev</summary>
        ///<see href="https://fontawesome.com/icons/dev?style=brands"/>
        [Description("Brands Dev"), IconID("fab-dev")]
        BrandsDev = 0xf6cc,
        ///<summary>Brands Deviantart</summary>
        ///<see href="https://fontawesome.com/icons/deviantart?style=brands"/>
        [Description("Brands Deviantart"), IconID("fab-deviantart")]
        BrandsDeviantart = 0xf1bd,
        ///<summary>Brands Dhl</summary>
        ///<see href="https://fontawesome.com/icons/dhl?style=brands"/>
        [Description("Brands Dhl"), IconID("fab-dhl")]
        BrandsDhl = 0xf790,
        ///<summary>Brands Diaspora</summary>
        ///<see href="https://fontawesome.com/icons/diaspora?style=brands"/>
        [Description("Brands Diaspora"), IconID("fab-diaspora")]
        BrandsDiaspora = 0xf791,
        ///<summary>Brands Digg</summary>
        ///<see href="https://fontawesome.com/icons/digg?style=brands"/>
        [Description("Brands Digg"), IconID("fab-digg")]
        BrandsDigg = 0xf1a6,
        ///<summary>Brands Digital Ocean</summary>
        ///<see href="https://fontawesome.com/icons/digital-ocean?style=brands"/>
        [Description("Brands Digital Ocean"), IconID("fab-digital-ocean")]
        BrandsDigitalOcean = 0xf391,
        ///<summary>Brands Discord</summary>
        ///<see href="https://fontawesome.com/icons/discord?style=brands"/>
        [Description("Brands Discord"), IconID("fab-discord")]
        BrandsDiscord = 0xf392,
        ///<summary>Brands Discourse</summary>
        ///<see href="https://fontawesome.com/icons/discourse?style=brands"/>
        [Description("Brands Discourse"), IconID("fab-discourse")]
        BrandsDiscourse = 0xf393,
        ///<summary>Brands Dochub</summary>
        ///<see href="https://fontawesome.com/icons/dochub?style=brands"/>
        [Description("Brands Dochub"), IconID("fab-dochub")]
        BrandsDochub = 0xf394,
        ///<summary>Brands Docker</summary>
        ///<see href="https://fontawesome.com/icons/docker?style=brands"/>
        [Description("Brands Docker"), IconID("fab-docker")]
        BrandsDocker = 0xf395,
        ///<summary>Brands Draft2digital</summary>
        ///<see href="https://fontawesome.com/icons/draft2digital?style=brands"/>
        [Description("Brands Draft2digital"), IconID("fab-draft2digital")]
        BrandsDraft2digital = 0xf396,
        ///<summary>Brands Dribbble</summary>
        ///<see href="https://fontawesome.com/icons/dribbble?style=brands"/>
        [Description("Brands Dribbble"), IconID("fab-dribbble")]
        BrandsDribbble = 0xf17d,
        ///<summary>Brands Dribbble Square</summary>
        ///<see href="https://fontawesome.com/icons/dribbble-square?style=brands"/>
        [Description("Brands Dribbble Square"), IconID("fab-dribbble-square")]
        BrandsDribbbleSquare = 0xf397,
        ///<summary>Brands Dropbox</summary>
        ///<see href="https://fontawesome.com/icons/dropbox?style=brands"/>
        [Description("Brands Dropbox"), IconID("fab-dropbox")]
        BrandsDropbox = 0xf16b,
        ///<summary>Brands Drupal</summary>
        ///<see href="https://fontawesome.com/icons/drupal?style=brands"/>
        [Description("Brands Drupal"), IconID("fab-drupal")]
        BrandsDrupal = 0xf1a9,
        ///<summary>Brands Dyalog</summary>
        ///<see href="https://fontawesome.com/icons/dyalog?style=brands"/>
        [Description("Brands Dyalog"), IconID("fab-dyalog")]
        BrandsDyalog = 0xf399,
        ///<summary>Brands Earlybirds</summary>
        ///<see href="https://fontawesome.com/icons/earlybirds?style=brands"/>
        [Description("Brands Earlybirds"), IconID("fab-earlybirds")]
        BrandsEarlybirds = 0xf39a,
        ///<summary>Brands Ebay</summary>
        ///<see href="https://fontawesome.com/icons/ebay?style=brands"/>
        [Description("Brands Ebay"), IconID("fab-ebay")]
        BrandsEbay = 0xf4f4,
        ///<summary>Brands Edge</summary>
        ///<see href="https://fontawesome.com/icons/edge?style=brands"/>
        [Description("Brands Edge"), IconID("fab-edge")]
        BrandsEdge = 0xf282,
        ///<summary>Brands Edge Legacy</summary>
        ///<see href="https://fontawesome.com/icons/edge-legacy?style=brands"/>
        [Description("Brands Edge Legacy"), IconID("fab-edge-legacy")]
        BrandsEdgeLegacy = 0xe078,
        ///<summary>Brands Elementor</summary>
        ///<see href="https://fontawesome.com/icons/elementor?style=brands"/>
        [Description("Brands Elementor"), IconID("fab-elementor")]
        BrandsElementor = 0xf430,
        ///<summary>Brands Ello</summary>
        ///<see href="https://fontawesome.com/icons/ello?style=brands"/>
        [Description("Brands Ello"), IconID("fab-ello")]
        BrandsEllo = 0xf5f1,
        ///<summary>Brands Ember</summary>
        ///<see href="https://fontawesome.com/icons/ember?style=brands"/>
        [Description("Brands Ember"), IconID("fab-ember")]
        BrandsEmber = 0xf423,
        ///<summary>Brands Empire</summary>
        ///<see href="https://fontawesome.com/icons/empire?style=brands"/>
        [Description("Brands Empire"), IconID("fab-empire")]
        BrandsEmpire = 0xf1d1,
        ///<summary>Brands Envira</summary>
        ///<see href="https://fontawesome.com/icons/envira?style=brands"/>
        [Description("Brands Envira"), IconID("fab-envira")]
        BrandsEnvira = 0xf299,
        ///<summary>Brands Erlang</summary>
        ///<see href="https://fontawesome.com/icons/erlang?style=brands"/>
        [Description("Brands Erlang"), IconID("fab-erlang")]
        BrandsErlang = 0xf39d,
        ///<summary>Brands Ethereum</summary>
        ///<see href="https://fontawesome.com/icons/ethereum?style=brands"/>
        [Description("Brands Ethereum"), IconID("fab-ethereum")]
        BrandsEthereum = 0xf42e,
        ///<summary>Brands Etsy</summary>
        ///<see href="https://fontawesome.com/icons/etsy?style=brands"/>
        [Description("Brands Etsy"), IconID("fab-etsy")]
        BrandsEtsy = 0xf2d7,
        ///<summary>Brands Evernote</summary>
        ///<see href="https://fontawesome.com/icons/evernote?style=brands"/>
        [Description("Brands Evernote"), IconID("fab-evernote")]
        BrandsEvernote = 0xf839,
        ///<summary>Brands Expeditedssl</summary>
        ///<see href="https://fontawesome.com/icons/expeditedssl?style=brands"/>
        [Description("Brands Expeditedssl"), IconID("fab-expeditedssl")]
        BrandsExpeditedssl = 0xf23e,
        ///<summary>Brands Facebook</summary>
        ///<see href="https://fontawesome.com/icons/facebook?style=brands"/>
        [Description("Brands Facebook"), IconID("fab-facebook")]
        BrandsFacebook = 0xf09a,
        ///<summary>Brands Facebook F</summary>
        ///<see href="https://fontawesome.com/icons/facebook-f?style=brands"/>
        [Description("Brands Facebook F"), IconID("fab-facebook-f")]
        BrandsFacebookF = 0xf39e,
        ///<summary>Brands Facebook Messenger</summary>
        ///<see href="https://fontawesome.com/icons/facebook-messenger?style=brands"/>
        [Description("Brands Facebook Messenger"), IconID("fab-facebook-messenger")]
        BrandsFacebookMessenger = 0xf39f,
        ///<summary>Brands Facebook Square</summary>
        ///<see href="https://fontawesome.com/icons/facebook-square?style=brands"/>
        [Description("Brands Facebook Square"), IconID("fab-facebook-square")]
        BrandsFacebookSquare = 0xf082,
        ///<summary>Brands Fantasy Flight Games</summary>
        ///<see href="https://fontawesome.com/icons/fantasy-flight-games?style=brands"/>
        [Description("Brands Fantasy Flight Games"), IconID("fab-fantasy-flight-games")]
        BrandsFantasyFlightGames = 0xf6dc,
        ///<summary>Brands Fedex</summary>
        ///<see href="https://fontawesome.com/icons/fedex?style=brands"/>
        [Description("Brands Fedex"), IconID("fab-fedex")]
        BrandsFedex = 0xf797,
        ///<summary>Brands Fedora</summary>
        ///<see href="https://fontawesome.com/icons/fedora?style=brands"/>
        [Description("Brands Fedora"), IconID("fab-fedora")]
        BrandsFedora = 0xf798,
        ///<summary>Brands Figma</summary>
        ///<see href="https://fontawesome.com/icons/figma?style=brands"/>
        [Description("Brands Figma"), IconID("fab-figma")]
        BrandsFigma = 0xf799,
        ///<summary>Brands Firefox</summary>
        ///<see href="https://fontawesome.com/icons/firefox?style=brands"/>
        [Description("Brands Firefox"), IconID("fab-firefox")]
        BrandsFirefox = 0xf269,
        ///<summary>Brands Firefox Browser</summary>
        ///<see href="https://fontawesome.com/icons/firefox-browser?style=brands"/>
        [Description("Brands Firefox Browser"), IconID("fab-firefox-browser")]
        BrandsFirefoxBrowser = 0xe007,
        ///<summary>Brands First Order</summary>
        ///<see href="https://fontawesome.com/icons/first-order?style=brands"/>
        [Description("Brands First Order"), IconID("fab-first-order")]
        BrandsFirstOrder = 0xf2b0,
        ///<summary>Brands First Order Alt</summary>
        ///<see href="https://fontawesome.com/icons/first-order-alt?style=brands"/>
        [Description("Brands First Order Alt"), IconID("fab-first-order-alt")]
        BrandsFirstOrderAlt = 0xf50a,
        ///<summary>Brands Firstdraft</summary>
        ///<see href="https://fontawesome.com/icons/firstdraft?style=brands"/>
        [Description("Brands Firstdraft"), IconID("fab-firstdraft")]
        BrandsFirstdraft = 0xf3a1,
        ///<summary>Brands Flickr</summary>
        ///<see href="https://fontawesome.com/icons/flickr?style=brands"/>
        [Description("Brands Flickr"), IconID("fab-flickr")]
        BrandsFlickr = 0xf16e,
        ///<summary>Brands Flipboard</summary>
        ///<see href="https://fontawesome.com/icons/flipboard?style=brands"/>
        [Description("Brands Flipboard"), IconID("fab-flipboard")]
        BrandsFlipboard = 0xf44d,
        ///<summary>Brands Fly</summary>
        ///<see href="https://fontawesome.com/icons/fly?style=brands"/>
        [Description("Brands Fly"), IconID("fab-fly")]
        BrandsFly = 0xf417,
        ///<summary>Brands Font Awesome</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome?style=brands"/>
        [Description("Brands Font Awesome"), IconID("fab-font-awesome")]
        BrandsFontAwesome = 0xf2b4,
        ///<summary>Brands Font Awesome Alt</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-alt?style=brands"/>
        [Description("Brands Font Awesome Alt"), IconID("fab-font-awesome-alt")]
        BrandsFontAwesomeAlt = 0xf35c,
        ///<summary>Brands Font Awesome Flag</summary>
        ///<see href="https://fontawesome.com/icons/font-awesome-flag?style=brands"/>
        [Description("Brands Font Awesome Flag"), IconID("fab-font-awesome-flag")]
        BrandsFontAwesomeFlag = 0xf425,
        ///<summary>Brands Fonticons</summary>
        ///<see href="https://fontawesome.com/icons/fonticons?style=brands"/>
        [Description("Brands Fonticons"), IconID("fab-fonticons")]
        BrandsFonticons = 0xf280,
        ///<summary>Brands Fonticons Fi</summary>
        ///<see href="https://fontawesome.com/icons/fonticons-fi?style=brands"/>
        [Description("Brands Fonticons Fi"), IconID("fab-fonticons-fi")]
        BrandsFonticonsFi = 0xf3a2,
        ///<summary>Brands Fort Awesome</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome?style=brands"/>
        [Description("Brands Fort Awesome"), IconID("fab-fort-awesome")]
        BrandsFortAwesome = 0xf286,
        ///<summary>Brands Fort Awesome Alt</summary>
        ///<see href="https://fontawesome.com/icons/fort-awesome-alt?style=brands"/>
        [Description("Brands Fort Awesome Alt"), IconID("fab-fort-awesome-alt")]
        BrandsFortAwesomeAlt = 0xf3a3,
        ///<summary>Brands Forumbee</summary>
        ///<see href="https://fontawesome.com/icons/forumbee?style=brands"/>
        [Description("Brands Forumbee"), IconID("fab-forumbee")]
        BrandsForumbee = 0xf211,
        ///<summary>Brands Foursquare</summary>
        ///<see href="https://fontawesome.com/icons/foursquare?style=brands"/>
        [Description("Brands Foursquare"), IconID("fab-foursquare")]
        BrandsFoursquare = 0xf180,
        ///<summary>Brands Free Code Camp</summary>
        ///<see href="https://fontawesome.com/icons/free-code-camp?style=brands"/>
        [Description("Brands Free Code Camp"), IconID("fab-free-code-camp")]
        BrandsFreeCodeCamp = 0xf2c5,
        ///<summary>Brands Freebsd</summary>
        ///<see href="https://fontawesome.com/icons/freebsd?style=brands"/>
        [Description("Brands Freebsd"), IconID("fab-freebsd")]
        BrandsFreebsd = 0xf3a4,
        ///<summary>Brands Fulcrum</summary>
        ///<see href="https://fontawesome.com/icons/fulcrum?style=brands"/>
        [Description("Brands Fulcrum"), IconID("fab-fulcrum")]
        BrandsFulcrum = 0xf50b,
        ///<summary>Brands Galactic Republic</summary>
        ///<see href="https://fontawesome.com/icons/galactic-republic?style=brands"/>
        [Description("Brands Galactic Republic"), IconID("fab-galactic-republic")]
        BrandsGalacticRepublic = 0xf50c,
        ///<summary>Brands Galactic Senate</summary>
        ///<see href="https://fontawesome.com/icons/galactic-senate?style=brands"/>
        [Description("Brands Galactic Senate"), IconID("fab-galactic-senate")]
        BrandsGalacticSenate = 0xf50d,
        ///<summary>Brands Get Pocket</summary>
        ///<see href="https://fontawesome.com/icons/get-pocket?style=brands"/>
        [Description("Brands Get Pocket"), IconID("fab-get-pocket")]
        BrandsGetPocket = 0xf265,
        ///<summary>Brands Gg</summary>
        ///<see href="https://fontawesome.com/icons/gg?style=brands"/>
        [Description("Brands Gg"), IconID("fab-gg")]
        BrandsGg = 0xf260,
        ///<summary>Brands Gg Circle</summary>
        ///<see href="https://fontawesome.com/icons/gg-circle?style=brands"/>
        [Description("Brands Gg Circle"), IconID("fab-gg-circle")]
        BrandsGgCircle = 0xf261,
        ///<summary>Brands Git</summary>
        ///<see href="https://fontawesome.com/icons/git?style=brands"/>
        [Description("Brands Git"), IconID("fab-git")]
        BrandsGit = 0xf1d3,
        ///<summary>Brands Git Alt</summary>
        ///<see href="https://fontawesome.com/icons/git-alt?style=brands"/>
        [Description("Brands Git Alt"), IconID("fab-git-alt")]
        BrandsGitAlt = 0xf841,
        ///<summary>Brands Git Square</summary>
        ///<see href="https://fontawesome.com/icons/git-square?style=brands"/>
        [Description("Brands Git Square"), IconID("fab-git-square")]
        BrandsGitSquare = 0xf1d2,
        ///<summary>Brands Github</summary>
        ///<see href="https://fontawesome.com/icons/github?style=brands"/>
        [Description("Brands Github"), IconID("fab-github")]
        BrandsGithub = 0xf09b,
        ///<summary>Brands Github Alt</summary>
        ///<see href="https://fontawesome.com/icons/github-alt?style=brands"/>
        [Description("Brands Github Alt"), IconID("fab-github-alt")]
        BrandsGithubAlt = 0xf113,
        ///<summary>Brands Github Square</summary>
        ///<see href="https://fontawesome.com/icons/github-square?style=brands"/>
        [Description("Brands Github Square"), IconID("fab-github-square")]
        BrandsGithubSquare = 0xf092,
        ///<summary>Brands Gitkraken</summary>
        ///<see href="https://fontawesome.com/icons/gitkraken?style=brands"/>
        [Description("Brands Gitkraken"), IconID("fab-gitkraken")]
        BrandsGitkraken = 0xf3a6,
        ///<summary>Brands Gitlab</summary>
        ///<see href="https://fontawesome.com/icons/gitlab?style=brands"/>
        [Description("Brands Gitlab"), IconID("fab-gitlab")]
        BrandsGitlab = 0xf296,
        ///<summary>Brands Gitter</summary>
        ///<see href="https://fontawesome.com/icons/gitter?style=brands"/>
        [Description("Brands Gitter"), IconID("fab-gitter")]
        BrandsGitter = 0xf426,
        ///<summary>Brands Glide</summary>
        ///<see href="https://fontawesome.com/icons/glide?style=brands"/>
        [Description("Brands Glide"), IconID("fab-glide")]
        BrandsGlide = 0xf2a5,
        ///<summary>Brands Glide G</summary>
        ///<see href="https://fontawesome.com/icons/glide-g?style=brands"/>
        [Description("Brands Glide G"), IconID("fab-glide-g")]
        BrandsGlideG = 0xf2a6,
        ///<summary>Brands Gofore</summary>
        ///<see href="https://fontawesome.com/icons/gofore?style=brands"/>
        [Description("Brands Gofore"), IconID("fab-gofore")]
        BrandsGofore = 0xf3a7,
        ///<summary>Brands Goodreads</summary>
        ///<see href="https://fontawesome.com/icons/goodreads?style=brands"/>
        [Description("Brands Goodreads"), IconID("fab-goodreads")]
        BrandsGoodreads = 0xf3a8,
        ///<summary>Brands Goodreads G</summary>
        ///<see href="https://fontawesome.com/icons/goodreads-g?style=brands"/>
        [Description("Brands Goodreads G"), IconID("fab-goodreads-g")]
        BrandsGoodreadsG = 0xf3a9,
        ///<summary>Brands Google</summary>
        ///<see href="https://fontawesome.com/icons/google?style=brands"/>
        [Description("Brands Google"), IconID("fab-google")]
        BrandsGoogle = 0xf1a0,
        ///<summary>Brands Google Drive</summary>
        ///<see href="https://fontawesome.com/icons/google-drive?style=brands"/>
        [Description("Brands Google Drive"), IconID("fab-google-drive")]
        BrandsGoogleDrive = 0xf3aa,
        ///<summary>Brands Google Pay</summary>
        ///<see href="https://fontawesome.com/icons/google-pay?style=brands"/>
        [Description("Brands Google Pay"), IconID("fab-google-pay")]
        BrandsGooglePay = 0xe079,
        ///<summary>Brands Google Play</summary>
        ///<see href="https://fontawesome.com/icons/google-play?style=brands"/>
        [Description("Brands Google Play"), IconID("fab-google-play")]
        BrandsGooglePlay = 0xf3ab,
        ///<summary>Brands Google Plus</summary>
        ///<see href="https://fontawesome.com/icons/google-plus?style=brands"/>
        [Description("Brands Google Plus"), IconID("fab-google-plus")]
        BrandsGooglePlus = 0xf2b3,
        ///<summary>Brands Google Plus G</summary>
        ///<see href="https://fontawesome.com/icons/google-plus-g?style=brands"/>
        [Description("Brands Google Plus G"), IconID("fab-google-plus-g")]
        BrandsGooglePlusG = 0xf0d5,
        ///<summary>Brands Google Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/google-plus-square?style=brands"/>
        [Description("Brands Google Plus Square"), IconID("fab-google-plus-square")]
        BrandsGooglePlusSquare = 0xf0d4,
        ///<summary>Brands Google Wallet</summary>
        ///<see href="https://fontawesome.com/icons/google-wallet?style=brands"/>
        [Description("Brands Google Wallet"), IconID("fab-google-wallet")]
        BrandsGoogleWallet = 0xf1ee,
        ///<summary>Brands Gratipay</summary>
        ///<see href="https://fontawesome.com/icons/gratipay?style=brands"/>
        [Description("Brands Gratipay"), IconID("fab-gratipay")]
        BrandsGratipay = 0xf184,
        ///<summary>Brands Grav</summary>
        ///<see href="https://fontawesome.com/icons/grav?style=brands"/>
        [Description("Brands Grav"), IconID("fab-grav")]
        BrandsGrav = 0xf2d6,
        ///<summary>Brands Gripfire</summary>
        ///<see href="https://fontawesome.com/icons/gripfire?style=brands"/>
        [Description("Brands Gripfire"), IconID("fab-gripfire")]
        BrandsGripfire = 0xf3ac,
        ///<summary>Brands Grunt</summary>
        ///<see href="https://fontawesome.com/icons/grunt?style=brands"/>
        [Description("Brands Grunt"), IconID("fab-grunt")]
        BrandsGrunt = 0xf3ad,
        ///<summary>Brands Guilded</summary>
        ///<see href="https://fontawesome.com/icons/guilded?style=brands"/>
        [Description("Brands Guilded"), IconID("fab-guilded")]
        BrandsGuilded = 0xe07e,
        ///<summary>Brands Gulp</summary>
        ///<see href="https://fontawesome.com/icons/gulp?style=brands"/>
        [Description("Brands Gulp"), IconID("fab-gulp")]
        BrandsGulp = 0xf3ae,
        ///<summary>Brands Hacker News</summary>
        ///<see href="https://fontawesome.com/icons/hacker-news?style=brands"/>
        [Description("Brands Hacker News"), IconID("fab-hacker-news")]
        BrandsHackerNews = 0xf1d4,
        ///<summary>Brands Hacker News Square</summary>
        ///<see href="https://fontawesome.com/icons/hacker-news-square?style=brands"/>
        [Description("Brands Hacker News Square"), IconID("fab-hacker-news-square")]
        BrandsHackerNewsSquare = 0xf3af,
        ///<summary>Brands Hackerrank</summary>
        ///<see href="https://fontawesome.com/icons/hackerrank?style=brands"/>
        [Description("Brands Hackerrank"), IconID("fab-hackerrank")]
        BrandsHackerrank = 0xf5f7,
        ///<summary>Brands Hips</summary>
        ///<see href="https://fontawesome.com/icons/hips?style=brands"/>
        [Description("Brands Hips"), IconID("fab-hips")]
        BrandsHips = 0xf452,
        ///<summary>Brands Hire A Helper</summary>
        ///<see href="https://fontawesome.com/icons/hire-a-helper?style=brands"/>
        [Description("Brands Hire A Helper"), IconID("fab-hire-a-helper")]
        BrandsHireAHelper = 0xf3b0,
        ///<summary>Brands Hive</summary>
        ///<see href="https://fontawesome.com/icons/hive?style=brands"/>
        [Description("Brands Hive"), IconID("fab-hive")]
        BrandsHive = 0xe07f,
        ///<summary>Brands Hooli</summary>
        ///<see href="https://fontawesome.com/icons/hooli?style=brands"/>
        [Description("Brands Hooli"), IconID("fab-hooli")]
        BrandsHooli = 0xf427,
        ///<summary>Brands Hornbill</summary>
        ///<see href="https://fontawesome.com/icons/hornbill?style=brands"/>
        [Description("Brands Hornbill"), IconID("fab-hornbill")]
        BrandsHornbill = 0xf592,
        ///<summary>Brands Hotjar</summary>
        ///<see href="https://fontawesome.com/icons/hotjar?style=brands"/>
        [Description("Brands Hotjar"), IconID("fab-hotjar")]
        BrandsHotjar = 0xf3b1,
        ///<summary>Brands Houzz</summary>
        ///<see href="https://fontawesome.com/icons/houzz?style=brands"/>
        [Description("Brands Houzz"), IconID("fab-houzz")]
        BrandsHouzz = 0xf27c,
        ///<summary>Brands Html5</summary>
        ///<see href="https://fontawesome.com/icons/html5?style=brands"/>
        [Description("Brands Html5"), IconID("fab-html5")]
        BrandsHtml5 = 0xf13b,
        ///<summary>Brands Hubspot</summary>
        ///<see href="https://fontawesome.com/icons/hubspot?style=brands"/>
        [Description("Brands Hubspot"), IconID("fab-hubspot")]
        BrandsHubspot = 0xf3b2,
        ///<summary>Brands Ideal</summary>
        ///<see href="https://fontawesome.com/icons/ideal?style=brands"/>
        [Description("Brands Ideal"), IconID("fab-ideal")]
        BrandsIdeal = 0xe013,
        ///<summary>Brands Imdb</summary>
        ///<see href="https://fontawesome.com/icons/imdb?style=brands"/>
        [Description("Brands Imdb"), IconID("fab-imdb")]
        BrandsImdb = 0xf2d8,
        ///<summary>Brands Innosoft</summary>
        ///<see href="https://fontawesome.com/icons/innosoft?style=brands"/>
        [Description("Brands Innosoft"), IconID("fab-innosoft")]
        BrandsInnosoft = 0xe080,
        ///<summary>Brands Instagram</summary>
        ///<see href="https://fontawesome.com/icons/instagram?style=brands"/>
        [Description("Brands Instagram"), IconID("fab-instagram")]
        BrandsInstagram = 0xf16d,
        ///<summary>Brands Instagram Square</summary>
        ///<see href="https://fontawesome.com/icons/instagram-square?style=brands"/>
        [Description("Brands Instagram Square"), IconID("fab-instagram-square")]
        BrandsInstagramSquare = 0xe055,
        ///<summary>Brands Instalod</summary>
        ///<see href="https://fontawesome.com/icons/instalod?style=brands"/>
        [Description("Brands Instalod"), IconID("fab-instalod")]
        BrandsInstalod = 0xe081,
        ///<summary>Brands Intercom</summary>
        ///<see href="https://fontawesome.com/icons/intercom?style=brands"/>
        [Description("Brands Intercom"), IconID("fab-intercom")]
        BrandsIntercom = 0xf7af,
        ///<summary>Brands Internet Explorer</summary>
        ///<see href="https://fontawesome.com/icons/internet-explorer?style=brands"/>
        [Description("Brands Internet Explorer"), IconID("fab-internet-explorer")]
        BrandsInternetExplorer = 0xf26b,
        ///<summary>Brands Invision</summary>
        ///<see href="https://fontawesome.com/icons/invision?style=brands"/>
        [Description("Brands Invision"), IconID("fab-invision")]
        BrandsInvision = 0xf7b0,
        ///<summary>Brands Ioxhost</summary>
        ///<see href="https://fontawesome.com/icons/ioxhost?style=brands"/>
        [Description("Brands Ioxhost"), IconID("fab-ioxhost")]
        BrandsIoxhost = 0xf208,
        ///<summary>Brands Itch Io</summary>
        ///<see href="https://fontawesome.com/icons/itch-io?style=brands"/>
        [Description("Brands Itch Io"), IconID("fab-itch-io")]
        BrandsItchIo = 0xf83a,
        ///<summary>Brands Itunes</summary>
        ///<see href="https://fontawesome.com/icons/itunes?style=brands"/>
        [Description("Brands Itunes"), IconID("fab-itunes")]
        BrandsItunes = 0xf3b4,
        ///<summary>Brands Itunes Note</summary>
        ///<see href="https://fontawesome.com/icons/itunes-note?style=brands"/>
        [Description("Brands Itunes Note"), IconID("fab-itunes-note")]
        BrandsItunesNote = 0xf3b5,
        ///<summary>Brands Java</summary>
        ///<see href="https://fontawesome.com/icons/java?style=brands"/>
        [Description("Brands Java"), IconID("fab-java")]
        BrandsJava = 0xf4e4,
        ///<summary>Brands Jedi Order</summary>
        ///<see href="https://fontawesome.com/icons/jedi-order?style=brands"/>
        [Description("Brands Jedi Order"), IconID("fab-jedi-order")]
        BrandsJediOrder = 0xf50e,
        ///<summary>Brands Jenkins</summary>
        ///<see href="https://fontawesome.com/icons/jenkins?style=brands"/>
        [Description("Brands Jenkins"), IconID("fab-jenkins")]
        BrandsJenkins = 0xf3b6,
        ///<summary>Brands Jira</summary>
        ///<see href="https://fontawesome.com/icons/jira?style=brands"/>
        [Description("Brands Jira"), IconID("fab-jira")]
        BrandsJira = 0xf7b1,
        ///<summary>Brands Joget</summary>
        ///<see href="https://fontawesome.com/icons/joget?style=brands"/>
        [Description("Brands Joget"), IconID("fab-joget")]
        BrandsJoget = 0xf3b7,
        ///<summary>Brands Joomla</summary>
        ///<see href="https://fontawesome.com/icons/joomla?style=brands"/>
        [Description("Brands Joomla"), IconID("fab-joomla")]
        BrandsJoomla = 0xf1aa,
        ///<summary>Brands Js</summary>
        ///<see href="https://fontawesome.com/icons/js?style=brands"/>
        [Description("Brands Js"), IconID("fab-js")]
        BrandsJs = 0xf3b8,
        ///<summary>Brands Js Square</summary>
        ///<see href="https://fontawesome.com/icons/js-square?style=brands"/>
        [Description("Brands Js Square"), IconID("fab-js-square")]
        BrandsJsSquare = 0xf3b9,
        ///<summary>Brands Jsfiddle</summary>
        ///<see href="https://fontawesome.com/icons/jsfiddle?style=brands"/>
        [Description("Brands Jsfiddle"), IconID("fab-jsfiddle")]
        BrandsJsfiddle = 0xf1cc,
        ///<summary>Brands Kaggle</summary>
        ///<see href="https://fontawesome.com/icons/kaggle?style=brands"/>
        [Description("Brands Kaggle"), IconID("fab-kaggle")]
        BrandsKaggle = 0xf5fa,
        ///<summary>Brands Keybase</summary>
        ///<see href="https://fontawesome.com/icons/keybase?style=brands"/>
        [Description("Brands Keybase"), IconID("fab-keybase")]
        BrandsKeybase = 0xf4f5,
        ///<summary>Brands Keycdn</summary>
        ///<see href="https://fontawesome.com/icons/keycdn?style=brands"/>
        [Description("Brands Keycdn"), IconID("fab-keycdn")]
        BrandsKeycdn = 0xf3ba,
        ///<summary>Brands Kickstarter</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter?style=brands"/>
        [Description("Brands Kickstarter"), IconID("fab-kickstarter")]
        BrandsKickstarter = 0xf3bb,
        ///<summary>Brands Kickstarter K</summary>
        ///<see href="https://fontawesome.com/icons/kickstarter-k?style=brands"/>
        [Description("Brands Kickstarter K"), IconID("fab-kickstarter-k")]
        BrandsKickstarterK = 0xf3bc,
        ///<summary>Brands Korvue</summary>
        ///<see href="https://fontawesome.com/icons/korvue?style=brands"/>
        [Description("Brands Korvue"), IconID("fab-korvue")]
        BrandsKorvue = 0xf42f,
        ///<summary>Brands Laravel</summary>
        ///<see href="https://fontawesome.com/icons/laravel?style=brands"/>
        [Description("Brands Laravel"), IconID("fab-laravel")]
        BrandsLaravel = 0xf3bd,
        ///<summary>Brands Lastfm</summary>
        ///<see href="https://fontawesome.com/icons/lastfm?style=brands"/>
        [Description("Brands Lastfm"), IconID("fab-lastfm")]
        BrandsLastfm = 0xf202,
        ///<summary>Brands Lastfm Square</summary>
        ///<see href="https://fontawesome.com/icons/lastfm-square?style=brands"/>
        [Description("Brands Lastfm Square"), IconID("fab-lastfm-square")]
        BrandsLastfmSquare = 0xf203,
        ///<summary>Brands Leanpub</summary>
        ///<see href="https://fontawesome.com/icons/leanpub?style=brands"/>
        [Description("Brands Leanpub"), IconID("fab-leanpub")]
        BrandsLeanpub = 0xf212,
        ///<summary>Brands Less</summary>
        ///<see href="https://fontawesome.com/icons/less?style=brands"/>
        [Description("Brands Less"), IconID("fab-less")]
        BrandsLess = 0xf41d,
        ///<summary>Brands Line</summary>
        ///<see href="https://fontawesome.com/icons/line?style=brands"/>
        [Description("Brands Line"), IconID("fab-line")]
        BrandsLine = 0xf3c0,
        ///<summary>Brands Linkedin</summary>
        ///<see href="https://fontawesome.com/icons/linkedin?style=brands"/>
        [Description("Brands Linkedin"), IconID("fab-linkedin")]
        BrandsLinkedin = 0xf08c,
        ///<summary>Brands Linkedin In</summary>
        ///<see href="https://fontawesome.com/icons/linkedin-in?style=brands"/>
        [Description("Brands Linkedin In"), IconID("fab-linkedin-in")]
        BrandsLinkedinIn = 0xf0e1,
        ///<summary>Brands Linode</summary>
        ///<see href="https://fontawesome.com/icons/linode?style=brands"/>
        [Description("Brands Linode"), IconID("fab-linode")]
        BrandsLinode = 0xf2b8,
        ///<summary>Brands Linux</summary>
        ///<see href="https://fontawesome.com/icons/linux?style=brands"/>
        [Description("Brands Linux"), IconID("fab-linux")]
        BrandsLinux = 0xf17c,
        ///<summary>Brands Lyft</summary>
        ///<see href="https://fontawesome.com/icons/lyft?style=brands"/>
        [Description("Brands Lyft"), IconID("fab-lyft")]
        BrandsLyft = 0xf3c3,
        ///<summary>Brands Magento</summary>
        ///<see href="https://fontawesome.com/icons/magento?style=brands"/>
        [Description("Brands Magento"), IconID("fab-magento")]
        BrandsMagento = 0xf3c4,
        ///<summary>Brands Mailchimp</summary>
        ///<see href="https://fontawesome.com/icons/mailchimp?style=brands"/>
        [Description("Brands Mailchimp"), IconID("fab-mailchimp")]
        BrandsMailchimp = 0xf59e,
        ///<summary>Brands Mandalorian</summary>
        ///<see href="https://fontawesome.com/icons/mandalorian?style=brands"/>
        [Description("Brands Mandalorian"), IconID("fab-mandalorian")]
        BrandsMandalorian = 0xf50f,
        ///<summary>Brands Markdown</summary>
        ///<see href="https://fontawesome.com/icons/markdown?style=brands"/>
        [Description("Brands Markdown"), IconID("fab-markdown")]
        BrandsMarkdown = 0xf60f,
        ///<summary>Brands Mastodon</summary>
        ///<see href="https://fontawesome.com/icons/mastodon?style=brands"/>
        [Description("Brands Mastodon"), IconID("fab-mastodon")]
        BrandsMastodon = 0xf4f6,
        ///<summary>Brands Maxcdn</summary>
        ///<see href="https://fontawesome.com/icons/maxcdn?style=brands"/>
        [Description("Brands Maxcdn"), IconID("fab-maxcdn")]
        BrandsMaxcdn = 0xf136,
        ///<summary>Brands Mdb</summary>
        ///<see href="https://fontawesome.com/icons/mdb?style=brands"/>
        [Description("Brands Mdb"), IconID("fab-mdb")]
        BrandsMdb = 0xf8ca,
        ///<summary>Brands Medapps</summary>
        ///<see href="https://fontawesome.com/icons/medapps?style=brands"/>
        [Description("Brands Medapps"), IconID("fab-medapps")]
        BrandsMedapps = 0xf3c6,
        ///<summary>Brands Medium</summary>
        ///<see href="https://fontawesome.com/icons/medium?style=brands"/>
        [Description("Brands Medium"), IconID("fab-medium")]
        BrandsMedium = 0xf23a,
        ///<summary>Brands Medium M</summary>
        ///<see href="https://fontawesome.com/icons/medium-m?style=brands"/>
        [Description("Brands Medium M"), IconID("fab-medium-m")]
        BrandsMediumM = 0xf3c7,
        ///<summary>Brands Medrt</summary>
        ///<see href="https://fontawesome.com/icons/medrt?style=brands"/>
        [Description("Brands Medrt"), IconID("fab-medrt")]
        BrandsMedrt = 0xf3c8,
        ///<summary>Brands Meetup</summary>
        ///<see href="https://fontawesome.com/icons/meetup?style=brands"/>
        [Description("Brands Meetup"), IconID("fab-meetup")]
        BrandsMeetup = 0xf2e0,
        ///<summary>Brands Megaport</summary>
        ///<see href="https://fontawesome.com/icons/megaport?style=brands"/>
        [Description("Brands Megaport"), IconID("fab-megaport")]
        BrandsMegaport = 0xf5a3,
        ///<summary>Brands Mendeley</summary>
        ///<see href="https://fontawesome.com/icons/mendeley?style=brands"/>
        [Description("Brands Mendeley"), IconID("fab-mendeley")]
        BrandsMendeley = 0xf7b3,
        ///<summary>Brands Microblog</summary>
        ///<see href="https://fontawesome.com/icons/microblog?style=brands"/>
        [Description("Brands Microblog"), IconID("fab-microblog")]
        BrandsMicroblog = 0xe01a,
        ///<summary>Brands Microsoft</summary>
        ///<see href="https://fontawesome.com/icons/microsoft?style=brands"/>
        [Description("Brands Microsoft"), IconID("fab-microsoft")]
        BrandsMicrosoft = 0xf3ca,
        ///<summary>Brands Mix</summary>
        ///<see href="https://fontawesome.com/icons/mix?style=brands"/>
        [Description("Brands Mix"), IconID("fab-mix")]
        BrandsMix = 0xf3cb,
        ///<summary>Brands Mixcloud</summary>
        ///<see href="https://fontawesome.com/icons/mixcloud?style=brands"/>
        [Description("Brands Mixcloud"), IconID("fab-mixcloud")]
        BrandsMixcloud = 0xf289,
        ///<summary>Brands Mixer</summary>
        ///<see href="https://fontawesome.com/icons/mixer?style=brands"/>
        [Description("Brands Mixer"), IconID("fab-mixer")]
        BrandsMixer = 0xe056,
        ///<summary>Brands Mizuni</summary>
        ///<see href="https://fontawesome.com/icons/mizuni?style=brands"/>
        [Description("Brands Mizuni"), IconID("fab-mizuni")]
        BrandsMizuni = 0xf3cc,
        ///<summary>Brands Modx</summary>
        ///<see href="https://fontawesome.com/icons/modx?style=brands"/>
        [Description("Brands Modx"), IconID("fab-modx")]
        BrandsModx = 0xf285,
        ///<summary>Brands Monero</summary>
        ///<see href="https://fontawesome.com/icons/monero?style=brands"/>
        [Description("Brands Monero"), IconID("fab-monero")]
        BrandsMonero = 0xf3d0,
        ///<summary>Brands Napster</summary>
        ///<see href="https://fontawesome.com/icons/napster?style=brands"/>
        [Description("Brands Napster"), IconID("fab-napster")]
        BrandsNapster = 0xf3d2,
        ///<summary>Brands Neos</summary>
        ///<see href="https://fontawesome.com/icons/neos?style=brands"/>
        [Description("Brands Neos"), IconID("fab-neos")]
        BrandsNeos = 0xf612,
        ///<summary>Brands Nimblr</summary>
        ///<see href="https://fontawesome.com/icons/nimblr?style=brands"/>
        [Description("Brands Nimblr"), IconID("fab-nimblr")]
        BrandsNimblr = 0xf5a8,
        ///<summary>Brands Node</summary>
        ///<see href="https://fontawesome.com/icons/node?style=brands"/>
        [Description("Brands Node"), IconID("fab-node")]
        BrandsNode = 0xf419,
        ///<summary>Brands Node Js</summary>
        ///<see href="https://fontawesome.com/icons/node-js?style=brands"/>
        [Description("Brands Node Js"), IconID("fab-node-js")]
        BrandsNodeJs = 0xf3d3,
        ///<summary>Brands Npm</summary>
        ///<see href="https://fontawesome.com/icons/npm?style=brands"/>
        [Description("Brands Npm"), IconID("fab-npm")]
        BrandsNpm = 0xf3d4,
        ///<summary>Brands Ns8</summary>
        ///<see href="https://fontawesome.com/icons/ns8?style=brands"/>
        [Description("Brands Ns8"), IconID("fab-ns8")]
        BrandsNs8 = 0xf3d5,
        ///<summary>Brands Nutritionix</summary>
        ///<see href="https://fontawesome.com/icons/nutritionix?style=brands"/>
        [Description("Brands Nutritionix"), IconID("fab-nutritionix")]
        BrandsNutritionix = 0xf3d6,
        ///<summary>Brands Octopus Deploy</summary>
        ///<see href="https://fontawesome.com/icons/octopus-deploy?style=brands"/>
        [Description("Brands Octopus Deploy"), IconID("fab-octopus-deploy")]
        BrandsOctopusDeploy = 0xe082,
        ///<summary>Brands Odnoklassniki</summary>
        ///<see href="https://fontawesome.com/icons/odnoklassniki?style=brands"/>
        [Description("Brands Odnoklassniki"), IconID("fab-odnoklassniki")]
        BrandsOdnoklassniki = 0xf263,
        ///<summary>Brands Odnoklassniki Square</summary>
        ///<see href="https://fontawesome.com/icons/odnoklassniki-square?style=brands"/>
        [Description("Brands Odnoklassniki Square"), IconID("fab-odnoklassniki-square")]
        BrandsOdnoklassnikiSquare = 0xf264,
        ///<summary>Brands Old Republic</summary>
        ///<see href="https://fontawesome.com/icons/old-republic?style=brands"/>
        [Description("Brands Old Republic"), IconID("fab-old-republic")]
        BrandsOldRepublic = 0xf510,
        ///<summary>Brands Opencart</summary>
        ///<see href="https://fontawesome.com/icons/opencart?style=brands"/>
        [Description("Brands Opencart"), IconID("fab-opencart")]
        BrandsOpencart = 0xf23d,
        ///<summary>Brands Openid</summary>
        ///<see href="https://fontawesome.com/icons/openid?style=brands"/>
        [Description("Brands Openid"), IconID("fab-openid")]
        BrandsOpenid = 0xf19b,
        ///<summary>Brands Opera</summary>
        ///<see href="https://fontawesome.com/icons/opera?style=brands"/>
        [Description("Brands Opera"), IconID("fab-opera")]
        BrandsOpera = 0xf26a,
        ///<summary>Brands Optin Monster</summary>
        ///<see href="https://fontawesome.com/icons/optin-monster?style=brands"/>
        [Description("Brands Optin Monster"), IconID("fab-optin-monster")]
        BrandsOptinMonster = 0xf23c,
        ///<summary>Brands Orcid</summary>
        ///<see href="https://fontawesome.com/icons/orcid?style=brands"/>
        [Description("Brands Orcid"), IconID("fab-orcid")]
        BrandsOrcid = 0xf8d2,
        ///<summary>Brands Osi</summary>
        ///<see href="https://fontawesome.com/icons/osi?style=brands"/>
        [Description("Brands Osi"), IconID("fab-osi")]
        BrandsOsi = 0xf41a,
        ///<summary>Brands Page4</summary>
        ///<see href="https://fontawesome.com/icons/page4?style=brands"/>
        [Description("Brands Page4"), IconID("fab-page4")]
        BrandsPage4 = 0xf3d7,
        ///<summary>Brands Pagelines</summary>
        ///<see href="https://fontawesome.com/icons/pagelines?style=brands"/>
        [Description("Brands Pagelines"), IconID("fab-pagelines")]
        BrandsPagelines = 0xf18c,
        ///<summary>Brands Palfed</summary>
        ///<see href="https://fontawesome.com/icons/palfed?style=brands"/>
        [Description("Brands Palfed"), IconID("fab-palfed")]
        BrandsPalfed = 0xf3d8,
        ///<summary>Brands Patreon</summary>
        ///<see href="https://fontawesome.com/icons/patreon?style=brands"/>
        [Description("Brands Patreon"), IconID("fab-patreon")]
        BrandsPatreon = 0xf3d9,
        ///<summary>Brands Paypal</summary>
        ///<see href="https://fontawesome.com/icons/paypal?style=brands"/>
        [Description("Brands Paypal"), IconID("fab-paypal")]
        BrandsPaypal = 0xf1ed,
        ///<summary>Brands Penny Arcade</summary>
        ///<see href="https://fontawesome.com/icons/penny-arcade?style=brands"/>
        [Description("Brands Penny Arcade"), IconID("fab-penny-arcade")]
        BrandsPennyArcade = 0xf704,
        ///<summary>Brands Perbyte</summary>
        ///<see href="https://fontawesome.com/icons/perbyte?style=brands"/>
        [Description("Brands Perbyte"), IconID("fab-perbyte")]
        BrandsPerbyte = 0xe083,
        ///<summary>Brands Periscope</summary>
        ///<see href="https://fontawesome.com/icons/periscope?style=brands"/>
        [Description("Brands Periscope"), IconID("fab-periscope")]
        BrandsPeriscope = 0xf3da,
        ///<summary>Brands Phabricator</summary>
        ///<see href="https://fontawesome.com/icons/phabricator?style=brands"/>
        [Description("Brands Phabricator"), IconID("fab-phabricator")]
        BrandsPhabricator = 0xf3db,
        ///<summary>Brands Phoenix Framework</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-framework?style=brands"/>
        [Description("Brands Phoenix Framework"), IconID("fab-phoenix-framework")]
        BrandsPhoenixFramework = 0xf3dc,
        ///<summary>Brands Phoenix Squadron</summary>
        ///<see href="https://fontawesome.com/icons/phoenix-squadron?style=brands"/>
        [Description("Brands Phoenix Squadron"), IconID("fab-phoenix-squadron")]
        BrandsPhoenixSquadron = 0xf511,
        ///<summary>Brands Php</summary>
        ///<see href="https://fontawesome.com/icons/php?style=brands"/>
        [Description("Brands Php"), IconID("fab-php")]
        BrandsPhp = 0xf457,
        ///<summary>Brands Pied Piper</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper?style=brands"/>
        [Description("Brands Pied Piper"), IconID("fab-pied-piper")]
        BrandsPiedPiper = 0xf2ae,
        ///<summary>Brands Pied Piper Alt</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-alt?style=brands"/>
        [Description("Brands Pied Piper Alt"), IconID("fab-pied-piper-alt")]
        BrandsPiedPiperAlt = 0xf1a8,
        ///<summary>Brands Pied Piper Hat</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-hat?style=brands"/>
        [Description("Brands Pied Piper Hat"), IconID("fab-pied-piper-hat")]
        BrandsPiedPiperHat = 0xf4e5,
        ///<summary>Brands Pied Piper Pp</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-pp?style=brands"/>
        [Description("Brands Pied Piper Pp"), IconID("fab-pied-piper-pp")]
        BrandsPiedPiperPp = 0xf1a7,
        ///<summary>Brands Pied Piper Square</summary>
        ///<see href="https://fontawesome.com/icons/pied-piper-square?style=brands"/>
        [Description("Brands Pied Piper Square"), IconID("fab-pied-piper-square")]
        BrandsPiedPiperSquare = 0xe01e,
        ///<summary>Brands Pinterest</summary>
        ///<see href="https://fontawesome.com/icons/pinterest?style=brands"/>
        [Description("Brands Pinterest"), IconID("fab-pinterest")]
        BrandsPinterest = 0xf0d2,
        ///<summary>Brands Pinterest P</summary>
        ///<see href="https://fontawesome.com/icons/pinterest-p?style=brands"/>
        [Description("Brands Pinterest P"), IconID("fab-pinterest-p")]
        BrandsPinterestP = 0xf231,
        ///<summary>Brands Pinterest Square</summary>
        ///<see href="https://fontawesome.com/icons/pinterest-square?style=brands"/>
        [Description("Brands Pinterest Square"), IconID("fab-pinterest-square")]
        BrandsPinterestSquare = 0xf0d3,
        ///<summary>Brands Playstation</summary>
        ///<see href="https://fontawesome.com/icons/playstation?style=brands"/>
        [Description("Brands Playstation"), IconID("fab-playstation")]
        BrandsPlaystation = 0xf3df,
        ///<summary>Brands Product Hunt</summary>
        ///<see href="https://fontawesome.com/icons/product-hunt?style=brands"/>
        [Description("Brands Product Hunt"), IconID("fab-product-hunt")]
        BrandsProductHunt = 0xf288,
        ///<summary>Brands Pushed</summary>
        ///<see href="https://fontawesome.com/icons/pushed?style=brands"/>
        [Description("Brands Pushed"), IconID("fab-pushed")]
        BrandsPushed = 0xf3e1,
        ///<summary>Brands Python</summary>
        ///<see href="https://fontawesome.com/icons/python?style=brands"/>
        [Description("Brands Python"), IconID("fab-python")]
        BrandsPython = 0xf3e2,
        ///<summary>Brands Qq</summary>
        ///<see href="https://fontawesome.com/icons/qq?style=brands"/>
        [Description("Brands Qq"), IconID("fab-qq")]
        BrandsQq = 0xf1d6,
        ///<summary>Brands Quinscape</summary>
        ///<see href="https://fontawesome.com/icons/quinscape?style=brands"/>
        [Description("Brands Quinscape"), IconID("fab-quinscape")]
        BrandsQuinscape = 0xf459,
        ///<summary>Brands Quora</summary>
        ///<see href="https://fontawesome.com/icons/quora?style=brands"/>
        [Description("Brands Quora"), IconID("fab-quora")]
        BrandsQuora = 0xf2c4,
        ///<summary>Brands R Project</summary>
        ///<see href="https://fontawesome.com/icons/r-project?style=brands"/>
        [Description("Brands R Project"), IconID("fab-r-project")]
        BrandsRProject = 0xf4f7,
        ///<summary>Brands Raspberry Pi</summary>
        ///<see href="https://fontawesome.com/icons/raspberry-pi?style=brands"/>
        [Description("Brands Raspberry Pi"), IconID("fab-raspberry-pi")]
        BrandsRaspberryPi = 0xf7bb,
        ///<summary>Brands Ravelry</summary>
        ///<see href="https://fontawesome.com/icons/ravelry?style=brands"/>
        [Description("Brands Ravelry"), IconID("fab-ravelry")]
        BrandsRavelry = 0xf2d9,
        ///<summary>Brands React</summary>
        ///<see href="https://fontawesome.com/icons/react?style=brands"/>
        [Description("Brands React"), IconID("fab-react")]
        BrandsReact = 0xf41b,
        ///<summary>Brands Reacteurope</summary>
        ///<see href="https://fontawesome.com/icons/reacteurope?style=brands"/>
        [Description("Brands Reacteurope"), IconID("fab-reacteurope")]
        BrandsReacteurope = 0xf75d,
        ///<summary>Brands Readme</summary>
        ///<see href="https://fontawesome.com/icons/readme?style=brands"/>
        [Description("Brands Readme"), IconID("fab-readme")]
        BrandsReadme = 0xf4d5,
        ///<summary>Brands Rebel</summary>
        ///<see href="https://fontawesome.com/icons/rebel?style=brands"/>
        [Description("Brands Rebel"), IconID("fab-rebel")]
        BrandsRebel = 0xf1d0,
        ///<summary>Brands Red River</summary>
        ///<see href="https://fontawesome.com/icons/red-river?style=brands"/>
        [Description("Brands Red River"), IconID("fab-red-river")]
        BrandsRedRiver = 0xf3e3,
        ///<summary>Brands Reddit</summary>
        ///<see href="https://fontawesome.com/icons/reddit?style=brands"/>
        [Description("Brands Reddit"), IconID("fab-reddit")]
        BrandsReddit = 0xf1a1,
        ///<summary>Brands Reddit Alien</summary>
        ///<see href="https://fontawesome.com/icons/reddit-alien?style=brands"/>
        [Description("Brands Reddit Alien"), IconID("fab-reddit-alien")]
        BrandsRedditAlien = 0xf281,
        ///<summary>Brands Reddit Square</summary>
        ///<see href="https://fontawesome.com/icons/reddit-square?style=brands"/>
        [Description("Brands Reddit Square"), IconID("fab-reddit-square")]
        BrandsRedditSquare = 0xf1a2,
        ///<summary>Brands Redhat</summary>
        ///<see href="https://fontawesome.com/icons/redhat?style=brands"/>
        [Description("Brands Redhat"), IconID("fab-redhat")]
        BrandsRedhat = 0xf7bc,
        ///<summary>Brands Renren</summary>
        ///<see href="https://fontawesome.com/icons/renren?style=brands"/>
        [Description("Brands Renren"), IconID("fab-renren")]
        BrandsRenren = 0xf18b,
        ///<summary>Brands Replyd</summary>
        ///<see href="https://fontawesome.com/icons/replyd?style=brands"/>
        [Description("Brands Replyd"), IconID("fab-replyd")]
        BrandsReplyd = 0xf3e6,
        ///<summary>Brands Researchgate</summary>
        ///<see href="https://fontawesome.com/icons/researchgate?style=brands"/>
        [Description("Brands Researchgate"), IconID("fab-researchgate")]
        BrandsResearchgate = 0xf4f8,
        ///<summary>Brands Resolving</summary>
        ///<see href="https://fontawesome.com/icons/resolving?style=brands"/>
        [Description("Brands Resolving"), IconID("fab-resolving")]
        BrandsResolving = 0xf3e7,
        ///<summary>Brands Rev</summary>
        ///<see href="https://fontawesome.com/icons/rev?style=brands"/>
        [Description("Brands Rev"), IconID("fab-rev")]
        BrandsRev = 0xf5b2,
        ///<summary>Brands Rocketchat</summary>
        ///<see href="https://fontawesome.com/icons/rocketchat?style=brands"/>
        [Description("Brands Rocketchat"), IconID("fab-rocketchat")]
        BrandsRocketchat = 0xf3e8,
        ///<summary>Brands Rockrms</summary>
        ///<see href="https://fontawesome.com/icons/rockrms?style=brands"/>
        [Description("Brands Rockrms"), IconID("fab-rockrms")]
        BrandsRockrms = 0xf3e9,
        ///<summary>Brands Rust</summary>
        ///<see href="https://fontawesome.com/icons/rust?style=brands"/>
        [Description("Brands Rust"), IconID("fab-rust")]
        BrandsRust = 0xe07a,
        ///<summary>Brands Safari</summary>
        ///<see href="https://fontawesome.com/icons/safari?style=brands"/>
        [Description("Brands Safari"), IconID("fab-safari")]
        BrandsSafari = 0xf267,
        ///<summary>Brands Salesforce</summary>
        ///<see href="https://fontawesome.com/icons/salesforce?style=brands"/>
        [Description("Brands Salesforce"), IconID("fab-salesforce")]
        BrandsSalesforce = 0xf83b,
        ///<summary>Brands Sass</summary>
        ///<see href="https://fontawesome.com/icons/sass?style=brands"/>
        [Description("Brands Sass"), IconID("fab-sass")]
        BrandsSass = 0xf41e,
        ///<summary>Brands Schlix</summary>
        ///<see href="https://fontawesome.com/icons/schlix?style=brands"/>
        [Description("Brands Schlix"), IconID("fab-schlix")]
        BrandsSchlix = 0xf3ea,
        ///<summary>Brands Scribd</summary>
        ///<see href="https://fontawesome.com/icons/scribd?style=brands"/>
        [Description("Brands Scribd"), IconID("fab-scribd")]
        BrandsScribd = 0xf28a,
        ///<summary>Brands Searchengin</summary>
        ///<see href="https://fontawesome.com/icons/searchengin?style=brands"/>
        [Description("Brands Searchengin"), IconID("fab-searchengin")]
        BrandsSearchengin = 0xf3eb,
        ///<summary>Brands Sellcast</summary>
        ///<see href="https://fontawesome.com/icons/sellcast?style=brands"/>
        [Description("Brands Sellcast"), IconID("fab-sellcast")]
        BrandsSellcast = 0xf2da,
        ///<summary>Brands Sellsy</summary>
        ///<see href="https://fontawesome.com/icons/sellsy?style=brands"/>
        [Description("Brands Sellsy"), IconID("fab-sellsy")]
        BrandsSellsy = 0xf213,
        ///<summary>Brands Servicestack</summary>
        ///<see href="https://fontawesome.com/icons/servicestack?style=brands"/>
        [Description("Brands Servicestack"), IconID("fab-servicestack")]
        BrandsServicestack = 0xf3ec,
        ///<summary>Brands Shirtsinbulk</summary>
        ///<see href="https://fontawesome.com/icons/shirtsinbulk?style=brands"/>
        [Description("Brands Shirtsinbulk"), IconID("fab-shirtsinbulk")]
        BrandsShirtsinbulk = 0xf214,
        ///<summary>Brands Shopify</summary>
        ///<see href="https://fontawesome.com/icons/shopify?style=brands"/>
        [Description("Brands Shopify"), IconID("fab-shopify")]
        BrandsShopify = 0xe057,
        ///<summary>Brands Shopware</summary>
        ///<see href="https://fontawesome.com/icons/shopware?style=brands"/>
        [Description("Brands Shopware"), IconID("fab-shopware")]
        BrandsShopware = 0xf5b5,
        ///<summary>Brands Simplybuilt</summary>
        ///<see href="https://fontawesome.com/icons/simplybuilt?style=brands"/>
        [Description("Brands Simplybuilt"), IconID("fab-simplybuilt")]
        BrandsSimplybuilt = 0xf215,
        ///<summary>Brands Sistrix</summary>
        ///<see href="https://fontawesome.com/icons/sistrix?style=brands"/>
        [Description("Brands Sistrix"), IconID("fab-sistrix")]
        BrandsSistrix = 0xf3ee,
        ///<summary>Brands Sith</summary>
        ///<see href="https://fontawesome.com/icons/sith?style=brands"/>
        [Description("Brands Sith"), IconID("fab-sith")]
        BrandsSith = 0xf512,
        ///<summary>Brands Sketch</summary>
        ///<see href="https://fontawesome.com/icons/sketch?style=brands"/>
        [Description("Brands Sketch"), IconID("fab-sketch")]
        BrandsSketch = 0xf7c6,
        ///<summary>Brands Skyatlas</summary>
        ///<see href="https://fontawesome.com/icons/skyatlas?style=brands"/>
        [Description("Brands Skyatlas"), IconID("fab-skyatlas")]
        BrandsSkyatlas = 0xf216,
        ///<summary>Brands Skype</summary>
        ///<see href="https://fontawesome.com/icons/skype?style=brands"/>
        [Description("Brands Skype"), IconID("fab-skype")]
        BrandsSkype = 0xf17e,
        ///<summary>Brands Slack</summary>
        ///<see href="https://fontawesome.com/icons/slack?style=brands"/>
        [Description("Brands Slack"), IconID("fab-slack")]
        BrandsSlack = 0xf198,
        ///<summary>Brands Slack Hash</summary>
        ///<see href="https://fontawesome.com/icons/slack-hash?style=brands"/>
        [Description("Brands Slack Hash"), IconID("fab-slack-hash")]
        BrandsSlackHash = 0xf3ef,
        ///<summary>Brands Slideshare</summary>
        ///<see href="https://fontawesome.com/icons/slideshare?style=brands"/>
        [Description("Brands Slideshare"), IconID("fab-slideshare")]
        BrandsSlideshare = 0xf1e7,
        ///<summary>Brands Snapchat</summary>
        ///<see href="https://fontawesome.com/icons/snapchat?style=brands"/>
        [Description("Brands Snapchat"), IconID("fab-snapchat")]
        BrandsSnapchat = 0xf2ab,
        ///<summary>Brands Snapchat Ghost</summary>
        ///<see href="https://fontawesome.com/icons/snapchat-ghost?style=brands"/>
        [Description("Brands Snapchat Ghost"), IconID("fab-snapchat-ghost")]
        BrandsSnapchatGhost = 0xf2ac,
        ///<summary>Brands Snapchat Square</summary>
        ///<see href="https://fontawesome.com/icons/snapchat-square?style=brands"/>
        [Description("Brands Snapchat Square"), IconID("fab-snapchat-square")]
        BrandsSnapchatSquare = 0xf2ad,
        ///<summary>Brands Soundcloud</summary>
        ///<see href="https://fontawesome.com/icons/soundcloud?style=brands"/>
        [Description("Brands Soundcloud"), IconID("fab-soundcloud")]
        BrandsSoundcloud = 0xf1be,
        ///<summary>Brands Sourcetree</summary>
        ///<see href="https://fontawesome.com/icons/sourcetree?style=brands"/>
        [Description("Brands Sourcetree"), IconID("fab-sourcetree")]
        BrandsSourcetree = 0xf7d3,
        ///<summary>Brands Speakap</summary>
        ///<see href="https://fontawesome.com/icons/speakap?style=brands"/>
        [Description("Brands Speakap"), IconID("fab-speakap")]
        BrandsSpeakap = 0xf3f3,
        ///<summary>Brands Speaker Deck</summary>
        ///<see href="https://fontawesome.com/icons/speaker-deck?style=brands"/>
        [Description("Brands Speaker Deck"), IconID("fab-speaker-deck")]
        BrandsSpeakerDeck = 0xf83c,
        ///<summary>Brands Spotify</summary>
        ///<see href="https://fontawesome.com/icons/spotify?style=brands"/>
        [Description("Brands Spotify"), IconID("fab-spotify")]
        BrandsSpotify = 0xf1bc,
        ///<summary>Brands Squarespace</summary>
        ///<see href="https://fontawesome.com/icons/squarespace?style=brands"/>
        [Description("Brands Squarespace"), IconID("fab-squarespace")]
        BrandsSquarespace = 0xf5be,
        ///<summary>Brands Stack Exchange</summary>
        ///<see href="https://fontawesome.com/icons/stack-exchange?style=brands"/>
        [Description("Brands Stack Exchange"), IconID("fab-stack-exchange")]
        BrandsStackExchange = 0xf18d,
        ///<summary>Brands Stack Overflow</summary>
        ///<see href="https://fontawesome.com/icons/stack-overflow?style=brands"/>
        [Description("Brands Stack Overflow"), IconID("fab-stack-overflow")]
        BrandsStackOverflow = 0xf16c,
        ///<summary>Brands Stackpath</summary>
        ///<see href="https://fontawesome.com/icons/stackpath?style=brands"/>
        [Description("Brands Stackpath"), IconID("fab-stackpath")]
        BrandsStackpath = 0xf842,
        ///<summary>Brands Staylinked</summary>
        ///<see href="https://fontawesome.com/icons/staylinked?style=brands"/>
        [Description("Brands Staylinked"), IconID("fab-staylinked")]
        BrandsStaylinked = 0xf3f5,
        ///<summary>Brands Steam</summary>
        ///<see href="https://fontawesome.com/icons/steam?style=brands"/>
        [Description("Brands Steam"), IconID("fab-steam")]
        BrandsSteam = 0xf1b6,
        ///<summary>Brands Steam Square</summary>
        ///<see href="https://fontawesome.com/icons/steam-square?style=brands"/>
        [Description("Brands Steam Square"), IconID("fab-steam-square")]
        BrandsSteamSquare = 0xf1b7,
        ///<summary>Brands Steam Symbol</summary>
        ///<see href="https://fontawesome.com/icons/steam-symbol?style=brands"/>
        [Description("Brands Steam Symbol"), IconID("fab-steam-symbol")]
        BrandsSteamSymbol = 0xf3f6,
        ///<summary>Brands Sticker Mule</summary>
        ///<see href="https://fontawesome.com/icons/sticker-mule?style=brands"/>
        [Description("Brands Sticker Mule"), IconID("fab-sticker-mule")]
        BrandsStickerMule = 0xf3f7,
        ///<summary>Brands Strava</summary>
        ///<see href="https://fontawesome.com/icons/strava?style=brands"/>
        [Description("Brands Strava"), IconID("fab-strava")]
        BrandsStrava = 0xf428,
        ///<summary>Brands Stripe</summary>
        ///<see href="https://fontawesome.com/icons/stripe?style=brands"/>
        [Description("Brands Stripe"), IconID("fab-stripe")]
        BrandsStripe = 0xf429,
        ///<summary>Brands Stripe S</summary>
        ///<see href="https://fontawesome.com/icons/stripe-s?style=brands"/>
        [Description("Brands Stripe S"), IconID("fab-stripe-s")]
        BrandsStripeS = 0xf42a,
        ///<summary>Brands Studiovinari</summary>
        ///<see href="https://fontawesome.com/icons/studiovinari?style=brands"/>
        [Description("Brands Studiovinari"), IconID("fab-studiovinari")]
        BrandsStudiovinari = 0xf3f8,
        ///<summary>Brands Stumbleupon</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon?style=brands"/>
        [Description("Brands Stumbleupon"), IconID("fab-stumbleupon")]
        BrandsStumbleupon = 0xf1a4,
        ///<summary>Brands Stumbleupon Circle</summary>
        ///<see href="https://fontawesome.com/icons/stumbleupon-circle?style=brands"/>
        [Description("Brands Stumbleupon Circle"), IconID("fab-stumbleupon-circle")]
        BrandsStumbleuponCircle = 0xf1a3,
        ///<summary>Brands Superpowers</summary>
        ///<see href="https://fontawesome.com/icons/superpowers?style=brands"/>
        [Description("Brands Superpowers"), IconID("fab-superpowers")]
        BrandsSuperpowers = 0xf2dd,
        ///<summary>Brands Supple</summary>
        ///<see href="https://fontawesome.com/icons/supple?style=brands"/>
        [Description("Brands Supple"), IconID("fab-supple")]
        BrandsSupple = 0xf3f9,
        ///<summary>Brands Suse</summary>
        ///<see href="https://fontawesome.com/icons/suse?style=brands"/>
        [Description("Brands Suse"), IconID("fab-suse")]
        BrandsSuse = 0xf7d6,
        ///<summary>Brands Swift</summary>
        ///<see href="https://fontawesome.com/icons/swift?style=brands"/>
        [Description("Brands Swift"), IconID("fab-swift")]
        BrandsSwift = 0xf8e1,
        ///<summary>Brands Symfony</summary>
        ///<see href="https://fontawesome.com/icons/symfony?style=brands"/>
        [Description("Brands Symfony"), IconID("fab-symfony")]
        BrandsSymfony = 0xf83d,
        ///<summary>Brands Teamspeak</summary>
        ///<see href="https://fontawesome.com/icons/teamspeak?style=brands"/>
        [Description("Brands Teamspeak"), IconID("fab-teamspeak")]
        BrandsTeamspeak = 0xf4f9,
        ///<summary>Brands Telegram</summary>
        ///<see href="https://fontawesome.com/icons/telegram?style=brands"/>
        [Description("Brands Telegram"), IconID("fab-telegram")]
        BrandsTelegram = 0xf2c6,
        ///<summary>Brands Telegram Plane</summary>
        ///<see href="https://fontawesome.com/icons/telegram-plane?style=brands"/>
        [Description("Brands Telegram Plane"), IconID("fab-telegram-plane")]
        BrandsTelegramPlane = 0xf3fe,
        ///<summary>Brands Tencent Weibo</summary>
        ///<see href="https://fontawesome.com/icons/tencent-weibo?style=brands"/>
        [Description("Brands Tencent Weibo"), IconID("fab-tencent-weibo")]
        BrandsTencentWeibo = 0xf1d5,
        ///<summary>Brands The Red Yeti</summary>
        ///<see href="https://fontawesome.com/icons/the-red-yeti?style=brands"/>
        [Description("Brands The Red Yeti"), IconID("fab-the-red-yeti")]
        BrandsTheRedYeti = 0xf69d,
        ///<summary>Brands Themeco</summary>
        ///<see href="https://fontawesome.com/icons/themeco?style=brands"/>
        [Description("Brands Themeco"), IconID("fab-themeco")]
        BrandsThemeco = 0xf5c6,
        ///<summary>Brands Themeisle</summary>
        ///<see href="https://fontawesome.com/icons/themeisle?style=brands"/>
        [Description("Brands Themeisle"), IconID("fab-themeisle")]
        BrandsThemeisle = 0xf2b2,
        ///<summary>Brands Think Peaks</summary>
        ///<see href="https://fontawesome.com/icons/think-peaks?style=brands"/>
        [Description("Brands Think Peaks"), IconID("fab-think-peaks")]
        BrandsThinkPeaks = 0xf731,
        ///<summary>Brands Tiktok</summary>
        ///<see href="https://fontawesome.com/icons/tiktok?style=brands"/>
        [Description("Brands Tiktok"), IconID("fab-tiktok")]
        BrandsTiktok = 0xe07b,
        ///<summary>Brands Trade Federation</summary>
        ///<see href="https://fontawesome.com/icons/trade-federation?style=brands"/>
        [Description("Brands Trade Federation"), IconID("fab-trade-federation")]
        BrandsTradeFederation = 0xf513,
        ///<summary>Brands Trello</summary>
        ///<see href="https://fontawesome.com/icons/trello?style=brands"/>
        [Description("Brands Trello"), IconID("fab-trello")]
        BrandsTrello = 0xf181,
        ///<summary>Brands Tripadvisor</summary>
        ///<see href="https://fontawesome.com/icons/tripadvisor?style=brands"/>
        [Description("Brands Tripadvisor"), IconID("fab-tripadvisor")]
        BrandsTripadvisor = 0xf262,
        ///<summary>Brands Tumblr</summary>
        ///<see href="https://fontawesome.com/icons/tumblr?style=brands"/>
        [Description("Brands Tumblr"), IconID("fab-tumblr")]
        BrandsTumblr = 0xf173,
        ///<summary>Brands Tumblr Square</summary>
        ///<see href="https://fontawesome.com/icons/tumblr-square?style=brands"/>
        [Description("Brands Tumblr Square"), IconID("fab-tumblr-square")]
        BrandsTumblrSquare = 0xf174,
        ///<summary>Brands Twitch</summary>
        ///<see href="https://fontawesome.com/icons/twitch?style=brands"/>
        [Description("Brands Twitch"), IconID("fab-twitch")]
        BrandsTwitch = 0xf1e8,
        ///<summary>Brands Twitter</summary>
        ///<see href="https://fontawesome.com/icons/twitter?style=brands"/>
        [Description("Brands Twitter"), IconID("fab-twitter")]
        BrandsTwitter = 0xf099,
        ///<summary>Brands Twitter Square</summary>
        ///<see href="https://fontawesome.com/icons/twitter-square?style=brands"/>
        [Description("Brands Twitter Square"), IconID("fab-twitter-square")]
        BrandsTwitterSquare = 0xf081,
        ///<summary>Brands Typo3</summary>
        ///<see href="https://fontawesome.com/icons/typo3?style=brands"/>
        [Description("Brands Typo3"), IconID("fab-typo3")]
        BrandsTypo3 = 0xf42b,
        ///<summary>Brands Uber</summary>
        ///<see href="https://fontawesome.com/icons/uber?style=brands"/>
        [Description("Brands Uber"), IconID("fab-uber")]
        BrandsUber = 0xf402,
        ///<summary>Brands Ubuntu</summary>
        ///<see href="https://fontawesome.com/icons/ubuntu?style=brands"/>
        [Description("Brands Ubuntu"), IconID("fab-ubuntu")]
        BrandsUbuntu = 0xf7df,
        ///<summary>Brands Uikit</summary>
        ///<see href="https://fontawesome.com/icons/uikit?style=brands"/>
        [Description("Brands Uikit"), IconID("fab-uikit")]
        BrandsUikit = 0xf403,
        ///<summary>Brands Umbraco</summary>
        ///<see href="https://fontawesome.com/icons/umbraco?style=brands"/>
        [Description("Brands Umbraco"), IconID("fab-umbraco")]
        BrandsUmbraco = 0xf8e8,
        ///<summary>Brands Uncharted</summary>
        ///<see href="https://fontawesome.com/icons/uncharted?style=brands"/>
        [Description("Brands Uncharted"), IconID("fab-uncharted")]
        BrandsUncharted = 0xe084,
        ///<summary>Brands Uniregistry</summary>
        ///<see href="https://fontawesome.com/icons/uniregistry?style=brands"/>
        [Description("Brands Uniregistry"), IconID("fab-uniregistry")]
        BrandsUniregistry = 0xf404,
        ///<summary>Brands Unity</summary>
        ///<see href="https://fontawesome.com/icons/unity?style=brands"/>
        [Description("Brands Unity"), IconID("fab-unity")]
        BrandsUnity = 0xe049,
        ///<summary>Brands Unsplash</summary>
        ///<see href="https://fontawesome.com/icons/unsplash?style=brands"/>
        [Description("Brands Unsplash"), IconID("fab-unsplash")]
        BrandsUnsplash = 0xe07c,
        ///<summary>Brands Untappd</summary>
        ///<see href="https://fontawesome.com/icons/untappd?style=brands"/>
        [Description("Brands Untappd"), IconID("fab-untappd")]
        BrandsUntappd = 0xf405,
        ///<summary>Brands Ups</summary>
        ///<see href="https://fontawesome.com/icons/ups?style=brands"/>
        [Description("Brands Ups"), IconID("fab-ups")]
        BrandsUps = 0xf7e0,
        ///<summary>Brands Usb</summary>
        ///<see href="https://fontawesome.com/icons/usb?style=brands"/>
        [Description("Brands Usb"), IconID("fab-usb")]
        BrandsUsb = 0xf287,
        ///<summary>Brands Usps</summary>
        ///<see href="https://fontawesome.com/icons/usps?style=brands"/>
        [Description("Brands Usps"), IconID("fab-usps")]
        BrandsUsps = 0xf7e1,
        ///<summary>Brands Ussunnah</summary>
        ///<see href="https://fontawesome.com/icons/ussunnah?style=brands"/>
        [Description("Brands Ussunnah"), IconID("fab-ussunnah")]
        BrandsUssunnah = 0xf407,
        ///<summary>Brands Vaadin</summary>
        ///<see href="https://fontawesome.com/icons/vaadin?style=brands"/>
        [Description("Brands Vaadin"), IconID("fab-vaadin")]
        BrandsVaadin = 0xf408,
        ///<summary>Brands Viacoin</summary>
        ///<see href="https://fontawesome.com/icons/viacoin?style=brands"/>
        [Description("Brands Viacoin"), IconID("fab-viacoin")]
        BrandsViacoin = 0xf237,
        ///<summary>Brands Viadeo</summary>
        ///<see href="https://fontawesome.com/icons/viadeo?style=brands"/>
        [Description("Brands Viadeo"), IconID("fab-viadeo")]
        BrandsViadeo = 0xf2a9,
        ///<summary>Brands Viadeo Square</summary>
        ///<see href="https://fontawesome.com/icons/viadeo-square?style=brands"/>
        [Description("Brands Viadeo Square"), IconID("fab-viadeo-square")]
        BrandsViadeoSquare = 0xf2aa,
        ///<summary>Brands Viber</summary>
        ///<see href="https://fontawesome.com/icons/viber?style=brands"/>
        [Description("Brands Viber"), IconID("fab-viber")]
        BrandsViber = 0xf409,
        ///<summary>Brands Vimeo</summary>
        ///<see href="https://fontawesome.com/icons/vimeo?style=brands"/>
        [Description("Brands Vimeo"), IconID("fab-vimeo")]
        BrandsVimeo = 0xf40a,
        ///<summary>Brands Vimeo Square</summary>
        ///<see href="https://fontawesome.com/icons/vimeo-square?style=brands"/>
        [Description("Brands Vimeo Square"), IconID("fab-vimeo-square")]
        BrandsVimeoSquare = 0xf194,
        ///<summary>Brands Vimeo V</summary>
        ///<see href="https://fontawesome.com/icons/vimeo-v?style=brands"/>
        [Description("Brands Vimeo V"), IconID("fab-vimeo-v")]
        BrandsVimeoV = 0xf27d,
        ///<summary>Brands Vine</summary>
        ///<see href="https://fontawesome.com/icons/vine?style=brands"/>
        [Description("Brands Vine"), IconID("fab-vine")]
        BrandsVine = 0xf1ca,
        ///<summary>Brands Vk</summary>
        ///<see href="https://fontawesome.com/icons/vk?style=brands"/>
        [Description("Brands Vk"), IconID("fab-vk")]
        BrandsVk = 0xf189,
        ///<summary>Brands Vnv</summary>
        ///<see href="https://fontawesome.com/icons/vnv?style=brands"/>
        [Description("Brands Vnv"), IconID("fab-vnv")]
        BrandsVnv = 0xf40b,
        ///<summary>Brands Vuejs</summary>
        ///<see href="https://fontawesome.com/icons/vuejs?style=brands"/>
        [Description("Brands Vuejs"), IconID("fab-vuejs")]
        BrandsVuejs = 0xf41f,
        ///<summary>Brands Watchman Monitoring</summary>
        ///<see href="https://fontawesome.com/icons/watchman-monitoring?style=brands"/>
        [Description("Brands Watchman Monitoring"), IconID("fab-watchman-monitoring")]
        BrandsWatchmanMonitoring = 0xe087,
        ///<summary>Brands Waze</summary>
        ///<see href="https://fontawesome.com/icons/waze?style=brands"/>
        [Description("Brands Waze"), IconID("fab-waze")]
        BrandsWaze = 0xf83f,
        ///<summary>Brands Weebly</summary>
        ///<see href="https://fontawesome.com/icons/weebly?style=brands"/>
        [Description("Brands Weebly"), IconID("fab-weebly")]
        BrandsWeebly = 0xf5cc,
        ///<summary>Brands Weibo</summary>
        ///<see href="https://fontawesome.com/icons/weibo?style=brands"/>
        [Description("Brands Weibo"), IconID("fab-weibo")]
        BrandsWeibo = 0xf18a,
        ///<summary>Brands Weixin</summary>
        ///<see href="https://fontawesome.com/icons/weixin?style=brands"/>
        [Description("Brands Weixin"), IconID("fab-weixin")]
        BrandsWeixin = 0xf1d7,
        ///<summary>Brands Whatsapp</summary>
        ///<see href="https://fontawesome.com/icons/whatsapp?style=brands"/>
        [Description("Brands Whatsapp"), IconID("fab-whatsapp")]
        BrandsWhatsapp = 0xf232,
        ///<summary>Brands Whatsapp Square</summary>
        ///<see href="https://fontawesome.com/icons/whatsapp-square?style=brands"/>
        [Description("Brands Whatsapp Square"), IconID("fab-whatsapp-square")]
        BrandsWhatsappSquare = 0xf40c,
        ///<summary>Brands Whmcs</summary>
        ///<see href="https://fontawesome.com/icons/whmcs?style=brands"/>
        [Description("Brands Whmcs"), IconID("fab-whmcs")]
        BrandsWhmcs = 0xf40d,
        ///<summary>Brands Wikipedia W</summary>
        ///<see href="https://fontawesome.com/icons/wikipedia-w?style=brands"/>
        [Description("Brands Wikipedia W"), IconID("fab-wikipedia-w")]
        BrandsWikipediaW = 0xf266,
        ///<summary>Brands Windows</summary>
        ///<see href="https://fontawesome.com/icons/windows?style=brands"/>
        [Description("Brands Windows"), IconID("fab-windows")]
        BrandsWindows = 0xf17a,
        ///<summary>Brands Wix</summary>
        ///<see href="https://fontawesome.com/icons/wix?style=brands"/>
        [Description("Brands Wix"), IconID("fab-wix")]
        BrandsWix = 0xf5cf,
        ///<summary>Brands Wizards Of The Coast</summary>
        ///<see href="https://fontawesome.com/icons/wizards-of-the-coast?style=brands"/>
        [Description("Brands Wizards Of The Coast"), IconID("fab-wizards-of-the-coast")]
        BrandsWizardsOfTheCoast = 0xf730,
        ///<summary>Brands Wodu</summary>
        ///<see href="https://fontawesome.com/icons/wodu?style=brands"/>
        [Description("Brands Wodu"), IconID("fab-wodu")]
        BrandsWodu = 0xe088,
        ///<summary>Brands Wolf Pack Battalion</summary>
        ///<see href="https://fontawesome.com/icons/wolf-pack-battalion?style=brands"/>
        [Description("Brands Wolf Pack Battalion"), IconID("fab-wolf-pack-battalion")]
        BrandsWolfPackBattalion = 0xf514,
        ///<summary>Brands Wordpress</summary>
        ///<see href="https://fontawesome.com/icons/wordpress?style=brands"/>
        [Description("Brands Wordpress"), IconID("fab-wordpress")]
        BrandsWordpress = 0xf19a,
        ///<summary>Brands Wordpress Simple</summary>
        ///<see href="https://fontawesome.com/icons/wordpress-simple?style=brands"/>
        [Description("Brands Wordpress Simple"), IconID("fab-wordpress-simple")]
        BrandsWordpressSimple = 0xf411,
        ///<summary>Brands Wpbeginner</summary>
        ///<see href="https://fontawesome.com/icons/wpbeginner?style=brands"/>
        [Description("Brands Wpbeginner"), IconID("fab-wpbeginner")]
        BrandsWpbeginner = 0xf297,
        ///<summary>Brands Wpexplorer</summary>
        ///<see href="https://fontawesome.com/icons/wpexplorer?style=brands"/>
        [Description("Brands Wpexplorer"), IconID("fab-wpexplorer")]
        BrandsWpexplorer = 0xf2de,
        ///<summary>Brands Wpforms</summary>
        ///<see href="https://fontawesome.com/icons/wpforms?style=brands"/>
        [Description("Brands Wpforms"), IconID("fab-wpforms")]
        BrandsWpforms = 0xf298,
        ///<summary>Brands Wpressr</summary>
        ///<see href="https://fontawesome.com/icons/wpressr?style=brands"/>
        [Description("Brands Wpressr"), IconID("fab-wpressr")]
        BrandsWpressr = 0xf3e4,
        ///<summary>Brands Xbox</summary>
        ///<see href="https://fontawesome.com/icons/xbox?style=brands"/>
        [Description("Brands Xbox"), IconID("fab-xbox")]
        BrandsXbox = 0xf412,
        ///<summary>Brands Xing</summary>
        ///<see href="https://fontawesome.com/icons/xing?style=brands"/>
        [Description("Brands Xing"), IconID("fab-xing")]
        BrandsXing = 0xf168,
        ///<summary>Brands Xing Square</summary>
        ///<see href="https://fontawesome.com/icons/xing-square?style=brands"/>
        [Description("Brands Xing Square"), IconID("fab-xing-square")]
        BrandsXingSquare = 0xf169,
        ///<summary>Brands Y Combinator</summary>
        ///<see href="https://fontawesome.com/icons/y-combinator?style=brands"/>
        [Description("Brands Y Combinator"), IconID("fab-y-combinator")]
        BrandsYCombinator = 0xf23b,
        ///<summary>Brands Yahoo</summary>
        ///<see href="https://fontawesome.com/icons/yahoo?style=brands"/>
        [Description("Brands Yahoo"), IconID("fab-yahoo")]
        BrandsYahoo = 0xf19e,
        ///<summary>Brands Yammer</summary>
        ///<see href="https://fontawesome.com/icons/yammer?style=brands"/>
        [Description("Brands Yammer"), IconID("fab-yammer")]
        BrandsYammer = 0xf840,
        ///<summary>Brands Yandex</summary>
        ///<see href="https://fontawesome.com/icons/yandex?style=brands"/>
        [Description("Brands Yandex"), IconID("fab-yandex")]
        BrandsYandex = 0xf413,
        ///<summary>Brands Yandex International</summary>
        ///<see href="https://fontawesome.com/icons/yandex-international?style=brands"/>
        [Description("Brands Yandex International"), IconID("fab-yandex-international")]
        BrandsYandexInternational = 0xf414,
        ///<summary>Brands Yarn</summary>
        ///<see href="https://fontawesome.com/icons/yarn?style=brands"/>
        [Description("Brands Yarn"), IconID("fab-yarn")]
        BrandsYarn = 0xf7e3,
        ///<summary>Brands Yelp</summary>
        ///<see href="https://fontawesome.com/icons/yelp?style=brands"/>
        [Description("Brands Yelp"), IconID("fab-yelp")]
        BrandsYelp = 0xf1e9,
        ///<summary>Brands Yoast</summary>
        ///<see href="https://fontawesome.com/icons/yoast?style=brands"/>
        [Description("Brands Yoast"), IconID("fab-yoast")]
        BrandsYoast = 0xf2b1,
        ///<summary>Brands Youtube</summary>
        ///<see href="https://fontawesome.com/icons/youtube?style=brands"/>
        [Description("Brands Youtube"), IconID("fab-youtube")]
        BrandsYoutube = 0xf167,
        ///<summary>Brands Youtube Square</summary>
        ///<see href="https://fontawesome.com/icons/youtube-square?style=brands"/>
        [Description("Brands Youtube Square"), IconID("fab-youtube-square")]
        BrandsYoutubeSquare = 0xf431,
        ///<summary>Brands Zhihu</summary>
        ///<see href="https://fontawesome.com/icons/zhihu?style=brands"/>
        [Description("Brands Zhihu"), IconID("fab-zhihu")]
        BrandsZhihu = 0xf63f,
        ///<summary>Regular Address Book</summary>
        ///<see href="https://fontawesome.com/icons/address-book?style=regular"/>
        [Description("Regular Address Book"), IconID("far-address-book")]
        RegularAddressBook = 0xf2b9,
        ///<summary>Regular Address Card</summary>
        ///<see href="https://fontawesome.com/icons/address-card?style=regular"/>
        [Description("Regular Address Card"), IconID("far-address-card")]
        RegularAddressCard = 0xf2bb,
        ///<summary>Regular Angry</summary>
        ///<see href="https://fontawesome.com/icons/angry?style=regular"/>
        [Description("Regular Angry"), IconID("far-angry")]
        RegularAngry = 0xf556,
        ///<summary>Regular Arrow Alt Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-down?style=regular"/>
        [Description("Regular Arrow Alt Circle Down"), IconID("far-arrow-alt-circle-down")]
        RegularArrowAltCircleDown = 0xf358,
        ///<summary>Regular Arrow Alt Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-left?style=regular"/>
        [Description("Regular Arrow Alt Circle Left"), IconID("far-arrow-alt-circle-left")]
        RegularArrowAltCircleLeft = 0xf359,
        ///<summary>Regular Arrow Alt Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-right?style=regular"/>
        [Description("Regular Arrow Alt Circle Right"), IconID("far-arrow-alt-circle-right")]
        RegularArrowAltCircleRight = 0xf35a,
        ///<summary>Regular Arrow Alt Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-up?style=regular"/>
        [Description("Regular Arrow Alt Circle Up"), IconID("far-arrow-alt-circle-up")]
        RegularArrowAltCircleUp = 0xf35b,
        ///<summary>Regular Bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=regular"/>
        [Description("Regular Bell"), IconID("far-bell")]
        RegularBell = 0xf0f3,
        ///<summary>Regular Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=regular"/>
        [Description("Regular Bell Slash"), IconID("far-bell-slash")]
        RegularBellSlash = 0xf1f6,
        ///<summary>Regular Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=regular"/>
        [Description("Regular Bookmark"), IconID("far-bookmark")]
        RegularBookmark = 0xf02e,
        ///<summary>Regular Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=regular"/>
        [Description("Regular Building"), IconID("far-building")]
        RegularBuilding = 0xf1ad,
        ///<summary>Regular Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=regular"/>
        [Description("Regular Calendar"), IconID("far-calendar")]
        RegularCalendar = 0xf133,
        ///<summary>Regular Calendar Alt</summary>
        ///<see href="https://fontawesome.com/icons/calendar-alt?style=regular"/>
        [Description("Regular Calendar Alt"), IconID("far-calendar-alt")]
        RegularCalendarAlt = 0xf073,
        ///<summary>Regular Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=regular"/>
        [Description("Regular Calendar Check"), IconID("far-calendar-check")]
        RegularCalendarCheck = 0xf274,
        ///<summary>Regular Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=regular"/>
        [Description("Regular Calendar Minus"), IconID("far-calendar-minus")]
        RegularCalendarMinus = 0xf272,
        ///<summary>Regular Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=regular"/>
        [Description("Regular Calendar Plus"), IconID("far-calendar-plus")]
        RegularCalendarPlus = 0xf271,
        ///<summary>Regular Calendar Times</summary>
        ///<see href="https://fontawesome.com/icons/calendar-times?style=regular"/>
        [Description("Regular Calendar Times"), IconID("far-calendar-times")]
        RegularCalendarTimes = 0xf273,
        ///<summary>Regular Caret Square Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-down?style=regular"/>
        [Description("Regular Caret Square Down"), IconID("far-caret-square-down")]
        RegularCaretSquareDown = 0xf150,
        ///<summary>Regular Caret Square Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-left?style=regular"/>
        [Description("Regular Caret Square Left"), IconID("far-caret-square-left")]
        RegularCaretSquareLeft = 0xf191,
        ///<summary>Regular Caret Square Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-right?style=regular"/>
        [Description("Regular Caret Square Right"), IconID("far-caret-square-right")]
        RegularCaretSquareRight = 0xf152,
        ///<summary>Regular Caret Square Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-up?style=regular"/>
        [Description("Regular Caret Square Up"), IconID("far-caret-square-up")]
        RegularCaretSquareUp = 0xf151,
        ///<summary>Regular Chart Bar</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=regular"/>
        [Description("Regular Chart Bar"), IconID("far-chart-bar")]
        RegularChartBar = 0xf080,
        ///<summary>Regular Check Circle</summary>
        ///<see href="https://fontawesome.com/icons/check-circle?style=regular"/>
        [Description("Regular Check Circle"), IconID("far-check-circle")]
        RegularCheckCircle = 0xf058,
        ///<summary>Regular Check Square</summary>
        ///<see href="https://fontawesome.com/icons/check-square?style=regular"/>
        [Description("Regular Check Square"), IconID("far-check-square")]
        RegularCheckSquare = 0xf14a,
        ///<summary>Regular Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=regular"/>
        [Description("Regular Circle"), IconID("far-circle")]
        RegularCircle = 0xf111,
        ///<summary>Regular Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=regular"/>
        [Description("Regular Clipboard"), IconID("far-clipboard")]
        RegularClipboard = 0xf328,
        ///<summary>Regular Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=regular"/>
        [Description("Regular Clock"), IconID("far-clock")]
        RegularClock = 0xf017,
        ///<summary>Regular Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=regular"/>
        [Description("Regular Clone"), IconID("far-clone")]
        RegularClone = 0xf24d,
        ///<summary>Regular Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=regular"/>
        [Description("Regular Closed Captioning"), IconID("far-closed-captioning")]
        RegularClosedCaptioning = 0xf20a,
        ///<summary>Regular Comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=regular"/>
        [Description("Regular Comment"), IconID("far-comment")]
        RegularComment = 0xf075,
        ///<summary>Regular Comment Alt</summary>
        ///<see href="https://fontawesome.com/icons/comment-alt?style=regular"/>
        [Description("Regular Comment Alt"), IconID("far-comment-alt")]
        RegularCommentAlt = 0xf27a,
        ///<summary>Regular Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=regular"/>
        [Description("Regular Comment Dots"), IconID("far-comment-dots")]
        RegularCommentDots = 0xf4ad,
        ///<summary>Regular Comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=regular"/>
        [Description("Regular Comments"), IconID("far-comments")]
        RegularComments = 0xf086,
        ///<summary>Regular Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=regular"/>
        [Description("Regular Compass"), IconID("far-compass")]
        RegularCompass = 0xf14e,
        ///<summary>Regular Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=regular"/>
        [Description("Regular Copy"), IconID("far-copy")]
        RegularCopy = 0xf0c5,
        ///<summary>Regular Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=regular"/>
        [Description("Regular Copyright"), IconID("far-copyright")]
        RegularCopyright = 0xf1f9,
        ///<summary>Regular Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=regular"/>
        [Description("Regular Credit Card"), IconID("far-credit-card")]
        RegularCreditCard = 0xf09d,
        ///<summary>Regular Dizzy</summary>
        ///<see href="https://fontawesome.com/icons/dizzy?style=regular"/>
        [Description("Regular Dizzy"), IconID("far-dizzy")]
        RegularDizzy = 0xf567,
        ///<summary>Regular Dot Circle</summary>
        ///<see href="https://fontawesome.com/icons/dot-circle?style=regular"/>
        [Description("Regular Dot Circle"), IconID("far-dot-circle")]
        RegularDotCircle = 0xf192,
        ///<summary>Regular Edit</summary>
        ///<see href="https://fontawesome.com/icons/edit?style=regular"/>
        [Description("Regular Edit"), IconID("far-edit")]
        RegularEdit = 0xf044,
        ///<summary>Regular Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=regular"/>
        [Description("Regular Envelope"), IconID("far-envelope")]
        RegularEnvelope = 0xf0e0,
        ///<summary>Regular Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=regular"/>
        [Description("Regular Envelope Open"), IconID("far-envelope-open")]
        RegularEnvelopeOpen = 0xf2b6,
        ///<summary>Regular Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=regular"/>
        [Description("Regular Eye"), IconID("far-eye")]
        RegularEye = 0xf06e,
        ///<summary>Regular Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=regular"/>
        [Description("Regular Eye Slash"), IconID("far-eye-slash")]
        RegularEyeSlash = 0xf070,
        ///<summary>Regular File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=regular"/>
        [Description("Regular File"), IconID("far-file")]
        RegularFile = 0xf15b,
        ///<summary>Regular File Alt</summary>
        ///<see href="https://fontawesome.com/icons/file-alt?style=regular"/>
        [Description("Regular File Alt"), IconID("far-file-alt")]
        RegularFileAlt = 0xf15c,
        ///<summary>Regular File Archive</summary>
        ///<see href="https://fontawesome.com/icons/file-archive?style=regular"/>
        [Description("Regular File Archive"), IconID("far-file-archive")]
        RegularFileArchive = 0xf1c6,
        ///<summary>Regular File Audio</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=regular"/>
        [Description("Regular File Audio"), IconID("far-file-audio")]
        RegularFileAudio = 0xf1c7,
        ///<summary>Regular File Code</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=regular"/>
        [Description("Regular File Code"), IconID("far-file-code")]
        RegularFileCode = 0xf1c9,
        ///<summary>Regular File Excel</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=regular"/>
        [Description("Regular File Excel"), IconID("far-file-excel")]
        RegularFileExcel = 0xf1c3,
        ///<summary>Regular File Image</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=regular"/>
        [Description("Regular File Image"), IconID("far-file-image")]
        RegularFileImage = 0xf1c5,
        ///<summary>Regular File Pdf</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=regular"/>
        [Description("Regular File Pdf"), IconID("far-file-pdf")]
        RegularFilePdf = 0xf1c1,
        ///<summary>Regular File Powerpoint</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=regular"/>
        [Description("Regular File Powerpoint"), IconID("far-file-powerpoint")]
        RegularFilePowerpoint = 0xf1c4,
        ///<summary>Regular File Video</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=regular"/>
        [Description("Regular File Video"), IconID("far-file-video")]
        RegularFileVideo = 0xf1c8,
        ///<summary>Regular File Word</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=regular"/>
        [Description("Regular File Word"), IconID("far-file-word")]
        RegularFileWord = 0xf1c2,
        ///<summary>Regular Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=regular"/>
        [Description("Regular Flag"), IconID("far-flag")]
        RegularFlag = 0xf024,
        ///<summary>Regular Flushed</summary>
        ///<see href="https://fontawesome.com/icons/flushed?style=regular"/>
        [Description("Regular Flushed"), IconID("far-flushed")]
        RegularFlushed = 0xf579,
        ///<summary>Regular Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=regular"/>
        [Description("Regular Folder"), IconID("far-folder")]
        RegularFolder = 0xf07b,
        ///<summary>Regular Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=regular"/>
        [Description("Regular Folder Open"), IconID("far-folder-open")]
        RegularFolderOpen = 0xf07c,
        ///<summary>Regular Frown</summary>
        ///<see href="https://fontawesome.com/icons/frown?style=regular"/>
        [Description("Regular Frown"), IconID("far-frown")]
        RegularFrown = 0xf119,
        ///<summary>Regular Frown Open</summary>
        ///<see href="https://fontawesome.com/icons/frown-open?style=regular"/>
        [Description("Regular Frown Open"), IconID("far-frown-open")]
        RegularFrownOpen = 0xf57a,
        ///<summary>Regular Futbol</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=regular"/>
        [Description("Regular Futbol"), IconID("far-futbol")]
        RegularFutbol = 0xf1e3,
        ///<summary>Regular Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=regular"/>
        [Description("Regular Gem"), IconID("far-gem")]
        RegularGem = 0xf3a5,
        ///<summary>Regular Grimace</summary>
        ///<see href="https://fontawesome.com/icons/grimace?style=regular"/>
        [Description("Regular Grimace"), IconID("far-grimace")]
        RegularGrimace = 0xf57f,
        ///<summary>Regular Grin</summary>
        ///<see href="https://fontawesome.com/icons/grin?style=regular"/>
        [Description("Regular Grin"), IconID("far-grin")]
        RegularGrin = 0xf580,
        ///<summary>Regular Grin Alt</summary>
        ///<see href="https://fontawesome.com/icons/grin-alt?style=regular"/>
        [Description("Regular Grin Alt"), IconID("far-grin-alt")]
        RegularGrinAlt = 0xf581,
        ///<summary>Regular Grin Beam</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam?style=regular"/>
        [Description("Regular Grin Beam"), IconID("far-grin-beam")]
        RegularGrinBeam = 0xf582,
        ///<summary>Regular Grin Beam Sweat</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam-sweat?style=regular"/>
        [Description("Regular Grin Beam Sweat"), IconID("far-grin-beam-sweat")]
        RegularGrinBeamSweat = 0xf583,
        ///<summary>Regular Grin Hearts</summary>
        ///<see href="https://fontawesome.com/icons/grin-hearts?style=regular"/>
        [Description("Regular Grin Hearts"), IconID("far-grin-hearts")]
        RegularGrinHearts = 0xf584,
        ///<summary>Regular Grin Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint?style=regular"/>
        [Description("Regular Grin Squint"), IconID("far-grin-squint")]
        RegularGrinSquint = 0xf585,
        ///<summary>Regular Grin Squint Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint-tears?style=regular"/>
        [Description("Regular Grin Squint Tears"), IconID("far-grin-squint-tears")]
        RegularGrinSquintTears = 0xf586,
        ///<summary>Regular Grin Stars</summary>
        ///<see href="https://fontawesome.com/icons/grin-stars?style=regular"/>
        [Description("Regular Grin Stars"), IconID("far-grin-stars")]
        RegularGrinStars = 0xf587,
        ///<summary>Regular Grin Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-tears?style=regular"/>
        [Description("Regular Grin Tears"), IconID("far-grin-tears")]
        RegularGrinTears = 0xf588,
        ///<summary>Regular Grin Tongue</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue?style=regular"/>
        [Description("Regular Grin Tongue"), IconID("far-grin-tongue")]
        RegularGrinTongue = 0xf589,
        ///<summary>Regular Grin Tongue Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-squint?style=regular"/>
        [Description("Regular Grin Tongue Squint"), IconID("far-grin-tongue-squint")]
        RegularGrinTongueSquint = 0xf58a,
        ///<summary>Regular Grin Tongue Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-wink?style=regular"/>
        [Description("Regular Grin Tongue Wink"), IconID("far-grin-tongue-wink")]
        RegularGrinTongueWink = 0xf58b,
        ///<summary>Regular Grin Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-wink?style=regular"/>
        [Description("Regular Grin Wink"), IconID("far-grin-wink")]
        RegularGrinWink = 0xf58c,
        ///<summary>Regular Hand Lizard</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=regular"/>
        [Description("Regular Hand Lizard"), IconID("far-hand-lizard")]
        RegularHandLizard = 0xf258,
        ///<summary>Regular Hand Paper</summary>
        ///<see href="https://fontawesome.com/icons/hand-paper?style=regular"/>
        [Description("Regular Hand Paper"), IconID("far-hand-paper")]
        RegularHandPaper = 0xf256,
        ///<summary>Regular Hand Peace</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=regular"/>
        [Description("Regular Hand Peace"), IconID("far-hand-peace")]
        RegularHandPeace = 0xf25b,
        ///<summary>Regular Hand Point Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=regular"/>
        [Description("Regular Hand Point Down"), IconID("far-hand-point-down")]
        RegularHandPointDown = 0xf0a7,
        ///<summary>Regular Hand Point Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=regular"/>
        [Description("Regular Hand Point Left"), IconID("far-hand-point-left")]
        RegularHandPointLeft = 0xf0a5,
        ///<summary>Regular Hand Point Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=regular"/>
        [Description("Regular Hand Point Right"), IconID("far-hand-point-right")]
        RegularHandPointRight = 0xf0a4,
        ///<summary>Regular Hand Point Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=regular"/>
        [Description("Regular Hand Point Up"), IconID("far-hand-point-up")]
        RegularHandPointUp = 0xf0a6,
        ///<summary>Regular Hand Pointer</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=regular"/>
        [Description("Regular Hand Pointer"), IconID("far-hand-pointer")]
        RegularHandPointer = 0xf25a,
        ///<summary>Regular Hand Rock</summary>
        ///<see href="https://fontawesome.com/icons/hand-rock?style=regular"/>
        [Description("Regular Hand Rock"), IconID("far-hand-rock")]
        RegularHandRock = 0xf255,
        ///<summary>Regular Hand Scissors</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=regular"/>
        [Description("Regular Hand Scissors"), IconID("far-hand-scissors")]
        RegularHandScissors = 0xf257,
        ///<summary>Regular Hand Spock</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=regular"/>
        [Description("Regular Hand Spock"), IconID("far-hand-spock")]
        RegularHandSpock = 0xf259,
        ///<summary>Regular Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=regular"/>
        [Description("Regular Handshake"), IconID("far-handshake")]
        RegularHandshake = 0xf2b5,
        ///<summary>Regular Hdd</summary>
        ///<see href="https://fontawesome.com/icons/hdd?style=regular"/>
        [Description("Regular Hdd"), IconID("far-hdd")]
        RegularHdd = 0xf0a0,
        ///<summary>Regular Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=regular"/>
        [Description("Regular Heart"), IconID("far-heart")]
        RegularHeart = 0xf004,
        ///<summary>Regular Hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=regular"/>
        [Description("Regular Hospital"), IconID("far-hospital")]
        RegularHospital = 0xf0f8,
        ///<summary>Regular Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=regular"/>
        [Description("Regular Hourglass"), IconID("far-hourglass")]
        RegularHourglass = 0xf254,
        ///<summary>Regular Id Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=regular"/>
        [Description("Regular Id Badge"), IconID("far-id-badge")]
        RegularIdBadge = 0xf2c1,
        ///<summary>Regular Id Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=regular"/>
        [Description("Regular Id Card"), IconID("far-id-card")]
        RegularIdCard = 0xf2c2,
        ///<summary>Regular Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=regular"/>
        [Description("Regular Image"), IconID("far-image")]
        RegularImage = 0xf03e,
        ///<summary>Regular Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=regular"/>
        [Description("Regular Images"), IconID("far-images")]
        RegularImages = 0xf302,
        ///<summary>Regular Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=regular"/>
        [Description("Regular Keyboard"), IconID("far-keyboard")]
        RegularKeyboard = 0xf11c,
        ///<summary>Regular Kiss</summary>
        ///<see href="https://fontawesome.com/icons/kiss?style=regular"/>
        [Description("Regular Kiss"), IconID("far-kiss")]
        RegularKiss = 0xf596,
        ///<summary>Regular Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/kiss-beam?style=regular"/>
        [Description("Regular Kiss Beam"), IconID("far-kiss-beam")]
        RegularKissBeam = 0xf597,
        ///<summary>Regular Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/kiss-wink-heart?style=regular"/>
        [Description("Regular Kiss Wink Heart"), IconID("far-kiss-wink-heart")]
        RegularKissWinkHeart = 0xf598,
        ///<summary>Regular Laugh</summary>
        ///<see href="https://fontawesome.com/icons/laugh?style=regular"/>
        [Description("Regular Laugh"), IconID("far-laugh")]
        RegularLaugh = 0xf599,
        ///<summary>Regular Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/laugh-beam?style=regular"/>
        [Description("Regular Laugh Beam"), IconID("far-laugh-beam")]
        RegularLaughBeam = 0xf59a,
        ///<summary>Regular Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/laugh-squint?style=regular"/>
        [Description("Regular Laugh Squint"), IconID("far-laugh-squint")]
        RegularLaughSquint = 0xf59b,
        ///<summary>Regular Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/laugh-wink?style=regular"/>
        [Description("Regular Laugh Wink"), IconID("far-laugh-wink")]
        RegularLaughWink = 0xf59c,
        ///<summary>Regular Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=regular"/>
        [Description("Regular Lemon"), IconID("far-lemon")]
        RegularLemon = 0xf094,
        ///<summary>Regular Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=regular"/>
        [Description("Regular Life Ring"), IconID("far-life-ring")]
        RegularLifeRing = 0xf1cd,
        ///<summary>Regular Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=regular"/>
        [Description("Regular Lightbulb"), IconID("far-lightbulb")]
        RegularLightbulb = 0xf0eb,
        ///<summary>Regular List Alt</summary>
        ///<see href="https://fontawesome.com/icons/list-alt?style=regular"/>
        [Description("Regular List Alt"), IconID("far-list-alt")]
        RegularListAlt = 0xf022,
        ///<summary>Regular Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=regular"/>
        [Description("Regular Map"), IconID("far-map")]
        RegularMap = 0xf279,
        ///<summary>Regular Meh</summary>
        ///<see href="https://fontawesome.com/icons/meh?style=regular"/>
        [Description("Regular Meh"), IconID("far-meh")]
        RegularMeh = 0xf11a,
        ///<summary>Regular Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/meh-blank?style=regular"/>
        [Description("Regular Meh Blank"), IconID("far-meh-blank")]
        RegularMehBlank = 0xf5a4,
        ///<summary>Regular Meh Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/meh-rolling-eyes?style=regular"/>
        [Description("Regular Meh Rolling Eyes"), IconID("far-meh-rolling-eyes")]
        RegularMehRollingEyes = 0xf5a5,
        ///<summary>Regular Minus Square</summary>
        ///<see href="https://fontawesome.com/icons/minus-square?style=regular"/>
        [Description("Regular Minus Square"), IconID("far-minus-square")]
        RegularMinusSquare = 0xf146,
        ///<summary>Regular Money Bill Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-alt?style=regular"/>
        [Description("Regular Money Bill Alt"), IconID("far-money-bill-alt")]
        RegularMoneyBillAlt = 0xf3d1,
        ///<summary>Regular Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=regular"/>
        [Description("Regular Moon"), IconID("far-moon")]
        RegularMoon = 0xf186,
        ///<summary>Regular Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=regular"/>
        [Description("Regular Newspaper"), IconID("far-newspaper")]
        RegularNewspaper = 0xf1ea,
        ///<summary>Regular Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=regular"/>
        [Description("Regular Object Group"), IconID("far-object-group")]
        RegularObjectGroup = 0xf247,
        ///<summary>Regular Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=regular"/>
        [Description("Regular Object Ungroup"), IconID("far-object-ungroup")]
        RegularObjectUngroup = 0xf248,
        ///<summary>Regular Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=regular"/>
        [Description("Regular Paper Plane"), IconID("far-paper-plane")]
        RegularPaperPlane = 0xf1d8,
        ///<summary>Regular Pause Circle</summary>
        ///<see href="https://fontawesome.com/icons/pause-circle?style=regular"/>
        [Description("Regular Pause Circle"), IconID("far-pause-circle")]
        RegularPauseCircle = 0xf28b,
        ///<summary>Regular Play Circle</summary>
        ///<see href="https://fontawesome.com/icons/play-circle?style=regular"/>
        [Description("Regular Play Circle"), IconID("far-play-circle")]
        RegularPlayCircle = 0xf144,
        ///<summary>Regular Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/plus-square?style=regular"/>
        [Description("Regular Plus Square"), IconID("far-plus-square")]
        RegularPlusSquare = 0xf0fe,
        ///<summary>Regular Question Circle</summary>
        ///<see href="https://fontawesome.com/icons/question-circle?style=regular"/>
        [Description("Regular Question Circle"), IconID("far-question-circle")]
        RegularQuestionCircle = 0xf059,
        ///<summary>Regular Registered</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=regular"/>
        [Description("Regular Registered"), IconID("far-registered")]
        RegularRegistered = 0xf25d,
        ///<summary>Regular Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/sad-cry?style=regular"/>
        [Description("Regular Sad Cry"), IconID("far-sad-cry")]
        RegularSadCry = 0xf5b3,
        ///<summary>Regular Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/sad-tear?style=regular"/>
        [Description("Regular Sad Tear"), IconID("far-sad-tear")]
        RegularSadTear = 0xf5b4,
        ///<summary>Regular Save</summary>
        ///<see href="https://fontawesome.com/icons/save?style=regular"/>
        [Description("Regular Save"), IconID("far-save")]
        RegularSave = 0xf0c7,
        ///<summary>Regular Share Square</summary>
        ///<see href="https://fontawesome.com/icons/share-square?style=regular"/>
        [Description("Regular Share Square"), IconID("far-share-square")]
        RegularShareSquare = 0xf14d,
        ///<summary>Regular Smile</summary>
        ///<see href="https://fontawesome.com/icons/smile?style=regular"/>
        [Description("Regular Smile"), IconID("far-smile")]
        RegularSmile = 0xf118,
        ///<summary>Regular Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/smile-beam?style=regular"/>
        [Description("Regular Smile Beam"), IconID("far-smile-beam")]
        RegularSmileBeam = 0xf5b8,
        ///<summary>Regular Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/smile-wink?style=regular"/>
        [Description("Regular Smile Wink"), IconID("far-smile-wink")]
        RegularSmileWink = 0xf4da,
        ///<summary>Regular Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=regular"/>
        [Description("Regular Snowflake"), IconID("far-snowflake")]
        RegularSnowflake = 0xf2dc,
        ///<summary>Regular Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=regular"/>
        [Description("Regular Square"), IconID("far-square")]
        RegularSquare = 0xf0c8,
        ///<summary>Regular Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=regular"/>
        [Description("Regular Star"), IconID("far-star")]
        RegularStar = 0xf005,
        ///<summary>Regular Star Half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=regular"/>
        [Description("Regular Star Half"), IconID("far-star-half")]
        RegularStarHalf = 0xf089,
        ///<summary>Regular Sticky Note</summary>
        ///<see href="https://fontawesome.com/icons/sticky-note?style=regular"/>
        [Description("Regular Sticky Note"), IconID("far-sticky-note")]
        RegularStickyNote = 0xf249,
        ///<summary>Regular Stop Circle</summary>
        ///<see href="https://fontawesome.com/icons/stop-circle?style=regular"/>
        [Description("Regular Stop Circle"), IconID("far-stop-circle")]
        RegularStopCircle = 0xf28d,
        ///<summary>Regular Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=regular"/>
        [Description("Regular Sun"), IconID("far-sun")]
        RegularSun = 0xf185,
        ///<summary>Regular Surprise</summary>
        ///<see href="https://fontawesome.com/icons/surprise?style=regular"/>
        [Description("Regular Surprise"), IconID("far-surprise")]
        RegularSurprise = 0xf5c2,
        ///<summary>Regular Thumbs Down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=regular"/>
        [Description("Regular Thumbs Down"), IconID("far-thumbs-down")]
        RegularThumbsDown = 0xf165,
        ///<summary>Regular Thumbs Up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=regular"/>
        [Description("Regular Thumbs Up"), IconID("far-thumbs-up")]
        RegularThumbsUp = 0xf164,
        ///<summary>Regular Times Circle</summary>
        ///<see href="https://fontawesome.com/icons/times-circle?style=regular"/>
        [Description("Regular Times Circle"), IconID("far-times-circle")]
        RegularTimesCircle = 0xf057,
        ///<summary>Regular Tired</summary>
        ///<see href="https://fontawesome.com/icons/tired?style=regular"/>
        [Description("Regular Tired"), IconID("far-tired")]
        RegularTired = 0xf5c8,
        ///<summary>Regular Trash Alt</summary>
        ///<see href="https://fontawesome.com/icons/trash-alt?style=regular"/>
        [Description("Regular Trash Alt"), IconID("far-trash-alt")]
        RegularTrashAlt = 0xf2ed,
        ///<summary>Regular User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=regular"/>
        [Description("Regular User"), IconID("far-user")]
        RegularUser = 0xf007,
        ///<summary>Regular User Circle</summary>
        ///<see href="https://fontawesome.com/icons/user-circle?style=regular"/>
        [Description("Regular User Circle"), IconID("far-user-circle")]
        RegularUserCircle = 0xf2bd,
        ///<summary>Regular Window Close</summary>
        ///<see href="https://fontawesome.com/icons/window-close?style=regular"/>
        [Description("Regular Window Close"), IconID("far-window-close")]
        RegularWindowClose = 0xf410,
        ///<summary>Regular Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=regular"/>
        [Description("Regular Window Maximize"), IconID("far-window-maximize")]
        RegularWindowMaximize = 0xf2d0,
        ///<summary>Regular Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=regular"/>
        [Description("Regular Window Minimize"), IconID("far-window-minimize")]
        RegularWindowMinimize = 0xf2d1,
        ///<summary>Regular Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=regular"/>
        [Description("Regular Window Restore"), IconID("far-window-restore")]
        RegularWindowRestore = 0xf2d2,
        ///<summary>Solid Ad</summary>
        ///<see href="https://fontawesome.com/icons/ad?style=solid"/>
        [Description("Solid Ad"), IconID("fas-ad")]
        SolidAd = 0xf641,
        ///<summary>Solid Address Book</summary>
        ///<see href="https://fontawesome.com/icons/address-book?style=solid"/>
        [Description("Solid Address Book"), IconID("fas-address-book")]
        SolidAddressBook = 0xf2b9,
        ///<summary>Solid Address Card</summary>
        ///<see href="https://fontawesome.com/icons/address-card?style=solid"/>
        [Description("Solid Address Card"), IconID("fas-address-card")]
        SolidAddressCard = 0xf2bb,
        ///<summary>Solid Adjust</summary>
        ///<see href="https://fontawesome.com/icons/adjust?style=solid"/>
        [Description("Solid Adjust"), IconID("fas-adjust")]
        SolidAdjust = 0xf042,
        ///<summary>Solid Air Freshener</summary>
        ///<see href="https://fontawesome.com/icons/air-freshener?style=solid"/>
        [Description("Solid Air Freshener"), IconID("fas-air-freshener")]
        SolidAirFreshener = 0xf5d0,
        ///<summary>Solid Align Center</summary>
        ///<see href="https://fontawesome.com/icons/align-center?style=solid"/>
        [Description("Solid Align Center"), IconID("fas-align-center")]
        SolidAlignCenter = 0xf037,
        ///<summary>Solid Align Justify</summary>
        ///<see href="https://fontawesome.com/icons/align-justify?style=solid"/>
        [Description("Solid Align Justify"), IconID("fas-align-justify")]
        SolidAlignJustify = 0xf039,
        ///<summary>Solid Align Left</summary>
        ///<see href="https://fontawesome.com/icons/align-left?style=solid"/>
        [Description("Solid Align Left"), IconID("fas-align-left")]
        SolidAlignLeft = 0xf036,
        ///<summary>Solid Align Right</summary>
        ///<see href="https://fontawesome.com/icons/align-right?style=solid"/>
        [Description("Solid Align Right"), IconID("fas-align-right")]
        SolidAlignRight = 0xf038,
        ///<summary>Solid Allergies</summary>
        ///<see href="https://fontawesome.com/icons/allergies?style=solid"/>
        [Description("Solid Allergies"), IconID("fas-allergies")]
        SolidAllergies = 0xf461,
        ///<summary>Solid Ambulance</summary>
        ///<see href="https://fontawesome.com/icons/ambulance?style=solid"/>
        [Description("Solid Ambulance"), IconID("fas-ambulance")]
        SolidAmbulance = 0xf0f9,
        ///<summary>Solid American Sign Language Interpreting</summary>
        ///<see href="https://fontawesome.com/icons/american-sign-language-interpreting?style=solid"/>
        [Description("Solid American Sign Language Interpreting"), IconID("fas-american-sign-language-interpreting")]
        SolidAmericanSignLanguageInterpreting = 0xf2a3,
        ///<summary>Solid Anchor</summary>
        ///<see href="https://fontawesome.com/icons/anchor?style=solid"/>
        [Description("Solid Anchor"), IconID("fas-anchor")]
        SolidAnchor = 0xf13d,
        ///<summary>Solid Angle Double Down</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-down?style=solid"/>
        [Description("Solid Angle Double Down"), IconID("fas-angle-double-down")]
        SolidAngleDoubleDown = 0xf103,
        ///<summary>Solid Angle Double Left</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-left?style=solid"/>
        [Description("Solid Angle Double Left"), IconID("fas-angle-double-left")]
        SolidAngleDoubleLeft = 0xf100,
        ///<summary>Solid Angle Double Right</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-right?style=solid"/>
        [Description("Solid Angle Double Right"), IconID("fas-angle-double-right")]
        SolidAngleDoubleRight = 0xf101,
        ///<summary>Solid Angle Double Up</summary>
        ///<see href="https://fontawesome.com/icons/angle-double-up?style=solid"/>
        [Description("Solid Angle Double Up"), IconID("fas-angle-double-up")]
        SolidAngleDoubleUp = 0xf102,
        ///<summary>Solid Angle Down</summary>
        ///<see href="https://fontawesome.com/icons/angle-down?style=solid"/>
        [Description("Solid Angle Down"), IconID("fas-angle-down")]
        SolidAngleDown = 0xf107,
        ///<summary>Solid Angle Left</summary>
        ///<see href="https://fontawesome.com/icons/angle-left?style=solid"/>
        [Description("Solid Angle Left"), IconID("fas-angle-left")]
        SolidAngleLeft = 0xf104,
        ///<summary>Solid Angle Right</summary>
        ///<see href="https://fontawesome.com/icons/angle-right?style=solid"/>
        [Description("Solid Angle Right"), IconID("fas-angle-right")]
        SolidAngleRight = 0xf105,
        ///<summary>Solid Angle Up</summary>
        ///<see href="https://fontawesome.com/icons/angle-up?style=solid"/>
        [Description("Solid Angle Up"), IconID("fas-angle-up")]
        SolidAngleUp = 0xf106,
        ///<summary>Solid Angry</summary>
        ///<see href="https://fontawesome.com/icons/angry?style=solid"/>
        [Description("Solid Angry"), IconID("fas-angry")]
        SolidAngry = 0xf556,
        ///<summary>Solid Ankh</summary>
        ///<see href="https://fontawesome.com/icons/ankh?style=solid"/>
        [Description("Solid Ankh"), IconID("fas-ankh")]
        SolidAnkh = 0xf644,
        ///<summary>Solid Apple Alt</summary>
        ///<see href="https://fontawesome.com/icons/apple-alt?style=solid"/>
        [Description("Solid Apple Alt"), IconID("fas-apple-alt")]
        SolidAppleAlt = 0xf5d1,
        ///<summary>Solid Archive</summary>
        ///<see href="https://fontawesome.com/icons/archive?style=solid"/>
        [Description("Solid Archive"), IconID("fas-archive")]
        SolidArchive = 0xf187,
        ///<summary>Solid Archway</summary>
        ///<see href="https://fontawesome.com/icons/archway?style=solid"/>
        [Description("Solid Archway"), IconID("fas-archway")]
        SolidArchway = 0xf557,
        ///<summary>Solid Arrow Alt Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-down?style=solid"/>
        [Description("Solid Arrow Alt Circle Down"), IconID("fas-arrow-alt-circle-down")]
        SolidArrowAltCircleDown = 0xf358,
        ///<summary>Solid Arrow Alt Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-left?style=solid"/>
        [Description("Solid Arrow Alt Circle Left"), IconID("fas-arrow-alt-circle-left")]
        SolidArrowAltCircleLeft = 0xf359,
        ///<summary>Solid Arrow Alt Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-right?style=solid"/>
        [Description("Solid Arrow Alt Circle Right"), IconID("fas-arrow-alt-circle-right")]
        SolidArrowAltCircleRight = 0xf35a,
        ///<summary>Solid Arrow Alt Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-alt-circle-up?style=solid"/>
        [Description("Solid Arrow Alt Circle Up"), IconID("fas-arrow-alt-circle-up")]
        SolidArrowAltCircleUp = 0xf35b,
        ///<summary>Solid Arrow Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-down?style=solid"/>
        [Description("Solid Arrow Circle Down"), IconID("fas-arrow-circle-down")]
        SolidArrowCircleDown = 0xf0ab,
        ///<summary>Solid Arrow Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-left?style=solid"/>
        [Description("Solid Arrow Circle Left"), IconID("fas-arrow-circle-left")]
        SolidArrowCircleLeft = 0xf0a8,
        ///<summary>Solid Arrow Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-right?style=solid"/>
        [Description("Solid Arrow Circle Right"), IconID("fas-arrow-circle-right")]
        SolidArrowCircleRight = 0xf0a9,
        ///<summary>Solid Arrow Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-circle-up?style=solid"/>
        [Description("Solid Arrow Circle Up"), IconID("fas-arrow-circle-up")]
        SolidArrowCircleUp = 0xf0aa,
        ///<summary>Solid Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/arrow-down?style=solid"/>
        [Description("Solid Arrow Down"), IconID("fas-arrow-down")]
        SolidArrowDown = 0xf063,
        ///<summary>Solid Arrow Left</summary>
        ///<see href="https://fontawesome.com/icons/arrow-left?style=solid"/>
        [Description("Solid Arrow Left"), IconID("fas-arrow-left")]
        SolidArrowLeft = 0xf060,
        ///<summary>Solid Arrow Right</summary>
        ///<see href="https://fontawesome.com/icons/arrow-right?style=solid"/>
        [Description("Solid Arrow Right"), IconID("fas-arrow-right")]
        SolidArrowRight = 0xf061,
        ///<summary>Solid Arrow Up</summary>
        ///<see href="https://fontawesome.com/icons/arrow-up?style=solid"/>
        [Description("Solid Arrow Up"), IconID("fas-arrow-up")]
        SolidArrowUp = 0xf062,
        ///<summary>Solid Arrows Alt</summary>
        ///<see href="https://fontawesome.com/icons/arrows-alt?style=solid"/>
        [Description("Solid Arrows Alt"), IconID("fas-arrows-alt")]
        SolidArrowsAlt = 0xf0b2,
        ///<summary>Solid Arrows Alt H</summary>
        ///<see href="https://fontawesome.com/icons/arrows-alt-h?style=solid"/>
        [Description("Solid Arrows Alt H"), IconID("fas-arrows-alt-h")]
        SolidArrowsAltH = 0xf337,
        ///<summary>Solid Arrows Alt V</summary>
        ///<see href="https://fontawesome.com/icons/arrows-alt-v?style=solid"/>
        [Description("Solid Arrows Alt V"), IconID("fas-arrows-alt-v")]
        SolidArrowsAltV = 0xf338,
        ///<summary>Solid Assistive Listening Systems</summary>
        ///<see href="https://fontawesome.com/icons/assistive-listening-systems?style=solid"/>
        [Description("Solid Assistive Listening Systems"), IconID("fas-assistive-listening-systems")]
        SolidAssistiveListeningSystems = 0xf2a2,
        ///<summary>Solid Asterisk</summary>
        ///<see href="https://fontawesome.com/icons/asterisk?style=solid"/>
        [Description("Solid Asterisk"), IconID("fas-asterisk")]
        SolidAsterisk = 0xf069,
        ///<summary>Solid At</summary>
        ///<see href="https://fontawesome.com/icons/at?style=solid"/>
        [Description("Solid At"), IconID("fas-at")]
        SolidAt = 0xf1fa,
        ///<summary>Solid Atlas</summary>
        ///<see href="https://fontawesome.com/icons/atlas?style=solid"/>
        [Description("Solid Atlas"), IconID("fas-atlas")]
        SolidAtlas = 0xf558,
        ///<summary>Solid Atom</summary>
        ///<see href="https://fontawesome.com/icons/atom?style=solid"/>
        [Description("Solid Atom"), IconID("fas-atom")]
        SolidAtom = 0xf5d2,
        ///<summary>Solid Audio Description</summary>
        ///<see href="https://fontawesome.com/icons/audio-description?style=solid"/>
        [Description("Solid Audio Description"), IconID("fas-audio-description")]
        SolidAudioDescription = 0xf29e,
        ///<summary>Solid Award</summary>
        ///<see href="https://fontawesome.com/icons/award?style=solid"/>
        [Description("Solid Award"), IconID("fas-award")]
        SolidAward = 0xf559,
        ///<summary>Solid Baby</summary>
        ///<see href="https://fontawesome.com/icons/baby?style=solid"/>
        [Description("Solid Baby"), IconID("fas-baby")]
        SolidBaby = 0xf77c,
        ///<summary>Solid Baby Carriage</summary>
        ///<see href="https://fontawesome.com/icons/baby-carriage?style=solid"/>
        [Description("Solid Baby Carriage"), IconID("fas-baby-carriage")]
        SolidBabyCarriage = 0xf77d,
        ///<summary>Solid Backspace</summary>
        ///<see href="https://fontawesome.com/icons/backspace?style=solid"/>
        [Description("Solid Backspace"), IconID("fas-backspace")]
        SolidBackspace = 0xf55a,
        ///<summary>Solid Backward</summary>
        ///<see href="https://fontawesome.com/icons/backward?style=solid"/>
        [Description("Solid Backward"), IconID("fas-backward")]
        SolidBackward = 0xf04a,
        ///<summary>Solid Bacon</summary>
        ///<see href="https://fontawesome.com/icons/bacon?style=solid"/>
        [Description("Solid Bacon"), IconID("fas-bacon")]
        SolidBacon = 0xf7e5,
        ///<summary>Solid Bacteria</summary>
        ///<see href="https://fontawesome.com/icons/bacteria?style=solid"/>
        [Description("Solid Bacteria"), IconID("fas-bacteria")]
        SolidBacteria = 0xe059,
        ///<summary>Solid Bacterium</summary>
        ///<see href="https://fontawesome.com/icons/bacterium?style=solid"/>
        [Description("Solid Bacterium"), IconID("fas-bacterium")]
        SolidBacterium = 0xe05a,
        ///<summary>Solid Bahai</summary>
        ///<see href="https://fontawesome.com/icons/bahai?style=solid"/>
        [Description("Solid Bahai"), IconID("fas-bahai")]
        SolidBahai = 0xf666,
        ///<summary>Solid Balance Scale</summary>
        ///<see href="https://fontawesome.com/icons/balance-scale?style=solid"/>
        [Description("Solid Balance Scale"), IconID("fas-balance-scale")]
        SolidBalanceScale = 0xf24e,
        ///<summary>Solid Balance Scale Left</summary>
        ///<see href="https://fontawesome.com/icons/balance-scale-left?style=solid"/>
        [Description("Solid Balance Scale Left"), IconID("fas-balance-scale-left")]
        SolidBalanceScaleLeft = 0xf515,
        ///<summary>Solid Balance Scale Right</summary>
        ///<see href="https://fontawesome.com/icons/balance-scale-right?style=solid"/>
        [Description("Solid Balance Scale Right"), IconID("fas-balance-scale-right")]
        SolidBalanceScaleRight = 0xf516,
        ///<summary>Solid Ban</summary>
        ///<see href="https://fontawesome.com/icons/ban?style=solid"/>
        [Description("Solid Ban"), IconID("fas-ban")]
        SolidBan = 0xf05e,
        ///<summary>Solid Band Aid</summary>
        ///<see href="https://fontawesome.com/icons/band-aid?style=solid"/>
        [Description("Solid Band Aid"), IconID("fas-band-aid")]
        SolidBandAid = 0xf462,
        ///<summary>Solid Barcode</summary>
        ///<see href="https://fontawesome.com/icons/barcode?style=solid"/>
        [Description("Solid Barcode"), IconID("fas-barcode")]
        SolidBarcode = 0xf02a,
        ///<summary>Solid Bars</summary>
        ///<see href="https://fontawesome.com/icons/bars?style=solid"/>
        [Description("Solid Bars"), IconID("fas-bars")]
        SolidBars = 0xf0c9,
        ///<summary>Solid Baseball Ball</summary>
        ///<see href="https://fontawesome.com/icons/baseball-ball?style=solid"/>
        [Description("Solid Baseball Ball"), IconID("fas-baseball-ball")]
        SolidBaseballBall = 0xf433,
        ///<summary>Solid Basketball Ball</summary>
        ///<see href="https://fontawesome.com/icons/basketball-ball?style=solid"/>
        [Description("Solid Basketball Ball"), IconID("fas-basketball-ball")]
        SolidBasketballBall = 0xf434,
        ///<summary>Solid Bath</summary>
        ///<see href="https://fontawesome.com/icons/bath?style=solid"/>
        [Description("Solid Bath"), IconID("fas-bath")]
        SolidBath = 0xf2cd,
        ///<summary>Solid Battery Empty</summary>
        ///<see href="https://fontawesome.com/icons/battery-empty?style=solid"/>
        [Description("Solid Battery Empty"), IconID("fas-battery-empty")]
        SolidBatteryEmpty = 0xf244,
        ///<summary>Solid Battery Full</summary>
        ///<see href="https://fontawesome.com/icons/battery-full?style=solid"/>
        [Description("Solid Battery Full"), IconID("fas-battery-full")]
        SolidBatteryFull = 0xf240,
        ///<summary>Solid Battery Half</summary>
        ///<see href="https://fontawesome.com/icons/battery-half?style=solid"/>
        [Description("Solid Battery Half"), IconID("fas-battery-half")]
        SolidBatteryHalf = 0xf242,
        ///<summary>Solid Battery Quarter</summary>
        ///<see href="https://fontawesome.com/icons/battery-quarter?style=solid"/>
        [Description("Solid Battery Quarter"), IconID("fas-battery-quarter")]
        SolidBatteryQuarter = 0xf243,
        ///<summary>Solid Battery Three Quarters</summary>
        ///<see href="https://fontawesome.com/icons/battery-three-quarters?style=solid"/>
        [Description("Solid Battery Three Quarters"), IconID("fas-battery-three-quarters")]
        SolidBatteryThreeQuarters = 0xf241,
        ///<summary>Solid Bed</summary>
        ///<see href="https://fontawesome.com/icons/bed?style=solid"/>
        [Description("Solid Bed"), IconID("fas-bed")]
        SolidBed = 0xf236,
        ///<summary>Solid Beer</summary>
        ///<see href="https://fontawesome.com/icons/beer?style=solid"/>
        [Description("Solid Beer"), IconID("fas-beer")]
        SolidBeer = 0xf0fc,
        ///<summary>Solid Bell</summary>
        ///<see href="https://fontawesome.com/icons/bell?style=solid"/>
        [Description("Solid Bell"), IconID("fas-bell")]
        SolidBell = 0xf0f3,
        ///<summary>Solid Bell Slash</summary>
        ///<see href="https://fontawesome.com/icons/bell-slash?style=solid"/>
        [Description("Solid Bell Slash"), IconID("fas-bell-slash")]
        SolidBellSlash = 0xf1f6,
        ///<summary>Solid Bezier Curve</summary>
        ///<see href="https://fontawesome.com/icons/bezier-curve?style=solid"/>
        [Description("Solid Bezier Curve"), IconID("fas-bezier-curve")]
        SolidBezierCurve = 0xf55b,
        ///<summary>Solid Bible</summary>
        ///<see href="https://fontawesome.com/icons/bible?style=solid"/>
        [Description("Solid Bible"), IconID("fas-bible")]
        SolidBible = 0xf647,
        ///<summary>Solid Bicycle</summary>
        ///<see href="https://fontawesome.com/icons/bicycle?style=solid"/>
        [Description("Solid Bicycle"), IconID("fas-bicycle")]
        SolidBicycle = 0xf206,
        ///<summary>Solid Biking</summary>
        ///<see href="https://fontawesome.com/icons/biking?style=solid"/>
        [Description("Solid Biking"), IconID("fas-biking")]
        SolidBiking = 0xf84a,
        ///<summary>Solid Binoculars</summary>
        ///<see href="https://fontawesome.com/icons/binoculars?style=solid"/>
        [Description("Solid Binoculars"), IconID("fas-binoculars")]
        SolidBinoculars = 0xf1e5,
        ///<summary>Solid Biohazard</summary>
        ///<see href="https://fontawesome.com/icons/biohazard?style=solid"/>
        [Description("Solid Biohazard"), IconID("fas-biohazard")]
        SolidBiohazard = 0xf780,
        ///<summary>Solid Birthday Cake</summary>
        ///<see href="https://fontawesome.com/icons/birthday-cake?style=solid"/>
        [Description("Solid Birthday Cake"), IconID("fas-birthday-cake")]
        SolidBirthdayCake = 0xf1fd,
        ///<summary>Solid Blender</summary>
        ///<see href="https://fontawesome.com/icons/blender?style=solid"/>
        [Description("Solid Blender"), IconID("fas-blender")]
        SolidBlender = 0xf517,
        ///<summary>Solid Blender Phone</summary>
        ///<see href="https://fontawesome.com/icons/blender-phone?style=solid"/>
        [Description("Solid Blender Phone"), IconID("fas-blender-phone")]
        SolidBlenderPhone = 0xf6b6,
        ///<summary>Solid Blind</summary>
        ///<see href="https://fontawesome.com/icons/blind?style=solid"/>
        [Description("Solid Blind"), IconID("fas-blind")]
        SolidBlind = 0xf29d,
        ///<summary>Solid Blog</summary>
        ///<see href="https://fontawesome.com/icons/blog?style=solid"/>
        [Description("Solid Blog"), IconID("fas-blog")]
        SolidBlog = 0xf781,
        ///<summary>Solid Bold</summary>
        ///<see href="https://fontawesome.com/icons/bold?style=solid"/>
        [Description("Solid Bold"), IconID("fas-bold")]
        SolidBold = 0xf032,
        ///<summary>Solid Bolt</summary>
        ///<see href="https://fontawesome.com/icons/bolt?style=solid"/>
        [Description("Solid Bolt"), IconID("fas-bolt")]
        SolidBolt = 0xf0e7,
        ///<summary>Solid Bomb</summary>
        ///<see href="https://fontawesome.com/icons/bomb?style=solid"/>
        [Description("Solid Bomb"), IconID("fas-bomb")]
        SolidBomb = 0xf1e2,
        ///<summary>Solid Bone</summary>
        ///<see href="https://fontawesome.com/icons/bone?style=solid"/>
        [Description("Solid Bone"), IconID("fas-bone")]
        SolidBone = 0xf5d7,
        ///<summary>Solid Bong</summary>
        ///<see href="https://fontawesome.com/icons/bong?style=solid"/>
        [Description("Solid Bong"), IconID("fas-bong")]
        SolidBong = 0xf55c,
        ///<summary>Solid Book</summary>
        ///<see href="https://fontawesome.com/icons/book?style=solid"/>
        [Description("Solid Book"), IconID("fas-book")]
        SolidBook = 0xf02d,
        ///<summary>Solid Book Dead</summary>
        ///<see href="https://fontawesome.com/icons/book-dead?style=solid"/>
        [Description("Solid Book Dead"), IconID("fas-book-dead")]
        SolidBookDead = 0xf6b7,
        ///<summary>Solid Book Medical</summary>
        ///<see href="https://fontawesome.com/icons/book-medical?style=solid"/>
        [Description("Solid Book Medical"), IconID("fas-book-medical")]
        SolidBookMedical = 0xf7e6,
        ///<summary>Solid Book Open</summary>
        ///<see href="https://fontawesome.com/icons/book-open?style=solid"/>
        [Description("Solid Book Open"), IconID("fas-book-open")]
        SolidBookOpen = 0xf518,
        ///<summary>Solid Book Reader</summary>
        ///<see href="https://fontawesome.com/icons/book-reader?style=solid"/>
        [Description("Solid Book Reader"), IconID("fas-book-reader")]
        SolidBookReader = 0xf5da,
        ///<summary>Solid Bookmark</summary>
        ///<see href="https://fontawesome.com/icons/bookmark?style=solid"/>
        [Description("Solid Bookmark"), IconID("fas-bookmark")]
        SolidBookmark = 0xf02e,
        ///<summary>Solid Border All</summary>
        ///<see href="https://fontawesome.com/icons/border-all?style=solid"/>
        [Description("Solid Border All"), IconID("fas-border-all")]
        SolidBorderAll = 0xf84c,
        ///<summary>Solid Border None</summary>
        ///<see href="https://fontawesome.com/icons/border-none?style=solid"/>
        [Description("Solid Border None"), IconID("fas-border-none")]
        SolidBorderNone = 0xf850,
        ///<summary>Solid Border Style</summary>
        ///<see href="https://fontawesome.com/icons/border-style?style=solid"/>
        [Description("Solid Border Style"), IconID("fas-border-style")]
        SolidBorderStyle = 0xf853,
        ///<summary>Solid Bowling Ball</summary>
        ///<see href="https://fontawesome.com/icons/bowling-ball?style=solid"/>
        [Description("Solid Bowling Ball"), IconID("fas-bowling-ball")]
        SolidBowlingBall = 0xf436,
        ///<summary>Solid Box</summary>
        ///<see href="https://fontawesome.com/icons/box?style=solid"/>
        [Description("Solid Box"), IconID("fas-box")]
        SolidBox = 0xf466,
        ///<summary>Solid Box Open</summary>
        ///<see href="https://fontawesome.com/icons/box-open?style=solid"/>
        [Description("Solid Box Open"), IconID("fas-box-open")]
        SolidBoxOpen = 0xf49e,
        ///<summary>Solid Box Tissue</summary>
        ///<see href="https://fontawesome.com/icons/box-tissue?style=solid"/>
        [Description("Solid Box Tissue"), IconID("fas-box-tissue")]
        SolidBoxTissue = 0xe05b,
        ///<summary>Solid Boxes</summary>
        ///<see href="https://fontawesome.com/icons/boxes?style=solid"/>
        [Description("Solid Boxes"), IconID("fas-boxes")]
        SolidBoxes = 0xf468,
        ///<summary>Solid Braille</summary>
        ///<see href="https://fontawesome.com/icons/braille?style=solid"/>
        [Description("Solid Braille"), IconID("fas-braille")]
        SolidBraille = 0xf2a1,
        ///<summary>Solid Brain</summary>
        ///<see href="https://fontawesome.com/icons/brain?style=solid"/>
        [Description("Solid Brain"), IconID("fas-brain")]
        SolidBrain = 0xf5dc,
        ///<summary>Solid Bread Slice</summary>
        ///<see href="https://fontawesome.com/icons/bread-slice?style=solid"/>
        [Description("Solid Bread Slice"), IconID("fas-bread-slice")]
        SolidBreadSlice = 0xf7ec,
        ///<summary>Solid Briefcase</summary>
        ///<see href="https://fontawesome.com/icons/briefcase?style=solid"/>
        [Description("Solid Briefcase"), IconID("fas-briefcase")]
        SolidBriefcase = 0xf0b1,
        ///<summary>Solid Briefcase Medical</summary>
        ///<see href="https://fontawesome.com/icons/briefcase-medical?style=solid"/>
        [Description("Solid Briefcase Medical"), IconID("fas-briefcase-medical")]
        SolidBriefcaseMedical = 0xf469,
        ///<summary>Solid Broadcast Tower</summary>
        ///<see href="https://fontawesome.com/icons/broadcast-tower?style=solid"/>
        [Description("Solid Broadcast Tower"), IconID("fas-broadcast-tower")]
        SolidBroadcastTower = 0xf519,
        ///<summary>Solid Broom</summary>
        ///<see href="https://fontawesome.com/icons/broom?style=solid"/>
        [Description("Solid Broom"), IconID("fas-broom")]
        SolidBroom = 0xf51a,
        ///<summary>Solid Brush</summary>
        ///<see href="https://fontawesome.com/icons/brush?style=solid"/>
        [Description("Solid Brush"), IconID("fas-brush")]
        SolidBrush = 0xf55d,
        ///<summary>Solid Bug</summary>
        ///<see href="https://fontawesome.com/icons/bug?style=solid"/>
        [Description("Solid Bug"), IconID("fas-bug")]
        SolidBug = 0xf188,
        ///<summary>Solid Building</summary>
        ///<see href="https://fontawesome.com/icons/building?style=solid"/>
        [Description("Solid Building"), IconID("fas-building")]
        SolidBuilding = 0xf1ad,
        ///<summary>Solid Bullhorn</summary>
        ///<see href="https://fontawesome.com/icons/bullhorn?style=solid"/>
        [Description("Solid Bullhorn"), IconID("fas-bullhorn")]
        SolidBullhorn = 0xf0a1,
        ///<summary>Solid Bullseye</summary>
        ///<see href="https://fontawesome.com/icons/bullseye?style=solid"/>
        [Description("Solid Bullseye"), IconID("fas-bullseye")]
        SolidBullseye = 0xf140,
        ///<summary>Solid Burn</summary>
        ///<see href="https://fontawesome.com/icons/burn?style=solid"/>
        [Description("Solid Burn"), IconID("fas-burn")]
        SolidBurn = 0xf46a,
        ///<summary>Solid Bus</summary>
        ///<see href="https://fontawesome.com/icons/bus?style=solid"/>
        [Description("Solid Bus"), IconID("fas-bus")]
        SolidBus = 0xf207,
        ///<summary>Solid Bus Alt</summary>
        ///<see href="https://fontawesome.com/icons/bus-alt?style=solid"/>
        [Description("Solid Bus Alt"), IconID("fas-bus-alt")]
        SolidBusAlt = 0xf55e,
        ///<summary>Solid Business Time</summary>
        ///<see href="https://fontawesome.com/icons/business-time?style=solid"/>
        [Description("Solid Business Time"), IconID("fas-business-time")]
        SolidBusinessTime = 0xf64a,
        ///<summary>Solid Calculator</summary>
        ///<see href="https://fontawesome.com/icons/calculator?style=solid"/>
        [Description("Solid Calculator"), IconID("fas-calculator")]
        SolidCalculator = 0xf1ec,
        ///<summary>Solid Calendar</summary>
        ///<see href="https://fontawesome.com/icons/calendar?style=solid"/>
        [Description("Solid Calendar"), IconID("fas-calendar")]
        SolidCalendar = 0xf133,
        ///<summary>Solid Calendar Alt</summary>
        ///<see href="https://fontawesome.com/icons/calendar-alt?style=solid"/>
        [Description("Solid Calendar Alt"), IconID("fas-calendar-alt")]
        SolidCalendarAlt = 0xf073,
        ///<summary>Solid Calendar Check</summary>
        ///<see href="https://fontawesome.com/icons/calendar-check?style=solid"/>
        [Description("Solid Calendar Check"), IconID("fas-calendar-check")]
        SolidCalendarCheck = 0xf274,
        ///<summary>Solid Calendar Day</summary>
        ///<see href="https://fontawesome.com/icons/calendar-day?style=solid"/>
        [Description("Solid Calendar Day"), IconID("fas-calendar-day")]
        SolidCalendarDay = 0xf783,
        ///<summary>Solid Calendar Minus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-minus?style=solid"/>
        [Description("Solid Calendar Minus"), IconID("fas-calendar-minus")]
        SolidCalendarMinus = 0xf272,
        ///<summary>Solid Calendar Plus</summary>
        ///<see href="https://fontawesome.com/icons/calendar-plus?style=solid"/>
        [Description("Solid Calendar Plus"), IconID("fas-calendar-plus")]
        SolidCalendarPlus = 0xf271,
        ///<summary>Solid Calendar Times</summary>
        ///<see href="https://fontawesome.com/icons/calendar-times?style=solid"/>
        [Description("Solid Calendar Times"), IconID("fas-calendar-times")]
        SolidCalendarTimes = 0xf273,
        ///<summary>Solid Calendar Week</summary>
        ///<see href="https://fontawesome.com/icons/calendar-week?style=solid"/>
        [Description("Solid Calendar Week"), IconID("fas-calendar-week")]
        SolidCalendarWeek = 0xf784,
        ///<summary>Solid Camera</summary>
        ///<see href="https://fontawesome.com/icons/camera?style=solid"/>
        [Description("Solid Camera"), IconID("fas-camera")]
        SolidCamera = 0xf030,
        ///<summary>Solid Camera Retro</summary>
        ///<see href="https://fontawesome.com/icons/camera-retro?style=solid"/>
        [Description("Solid Camera Retro"), IconID("fas-camera-retro")]
        SolidCameraRetro = 0xf083,
        ///<summary>Solid Campground</summary>
        ///<see href="https://fontawesome.com/icons/campground?style=solid"/>
        [Description("Solid Campground"), IconID("fas-campground")]
        SolidCampground = 0xf6bb,
        ///<summary>Solid Candy Cane</summary>
        ///<see href="https://fontawesome.com/icons/candy-cane?style=solid"/>
        [Description("Solid Candy Cane"), IconID("fas-candy-cane")]
        SolidCandyCane = 0xf786,
        ///<summary>Solid Cannabis</summary>
        ///<see href="https://fontawesome.com/icons/cannabis?style=solid"/>
        [Description("Solid Cannabis"), IconID("fas-cannabis")]
        SolidCannabis = 0xf55f,
        ///<summary>Solid Capsules</summary>
        ///<see href="https://fontawesome.com/icons/capsules?style=solid"/>
        [Description("Solid Capsules"), IconID("fas-capsules")]
        SolidCapsules = 0xf46b,
        ///<summary>Solid Car</summary>
        ///<see href="https://fontawesome.com/icons/car?style=solid"/>
        [Description("Solid Car"), IconID("fas-car")]
        SolidCar = 0xf1b9,
        ///<summary>Solid Car Alt</summary>
        ///<see href="https://fontawesome.com/icons/car-alt?style=solid"/>
        [Description("Solid Car Alt"), IconID("fas-car-alt")]
        SolidCarAlt = 0xf5de,
        ///<summary>Solid Car Battery</summary>
        ///<see href="https://fontawesome.com/icons/car-battery?style=solid"/>
        [Description("Solid Car Battery"), IconID("fas-car-battery")]
        SolidCarBattery = 0xf5df,
        ///<summary>Solid Car Crash</summary>
        ///<see href="https://fontawesome.com/icons/car-crash?style=solid"/>
        [Description("Solid Car Crash"), IconID("fas-car-crash")]
        SolidCarCrash = 0xf5e1,
        ///<summary>Solid Car Side</summary>
        ///<see href="https://fontawesome.com/icons/car-side?style=solid"/>
        [Description("Solid Car Side"), IconID("fas-car-side")]
        SolidCarSide = 0xf5e4,
        ///<summary>Solid Caravan</summary>
        ///<see href="https://fontawesome.com/icons/caravan?style=solid"/>
        [Description("Solid Caravan"), IconID("fas-caravan")]
        SolidCaravan = 0xf8ff,
        ///<summary>Solid Caret Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-down?style=solid"/>
        [Description("Solid Caret Down"), IconID("fas-caret-down")]
        SolidCaretDown = 0xf0d7,
        ///<summary>Solid Caret Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-left?style=solid"/>
        [Description("Solid Caret Left"), IconID("fas-caret-left")]
        SolidCaretLeft = 0xf0d9,
        ///<summary>Solid Caret Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-right?style=solid"/>
        [Description("Solid Caret Right"), IconID("fas-caret-right")]
        SolidCaretRight = 0xf0da,
        ///<summary>Solid Caret Square Down</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-down?style=solid"/>
        [Description("Solid Caret Square Down"), IconID("fas-caret-square-down")]
        SolidCaretSquareDown = 0xf150,
        ///<summary>Solid Caret Square Left</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-left?style=solid"/>
        [Description("Solid Caret Square Left"), IconID("fas-caret-square-left")]
        SolidCaretSquareLeft = 0xf191,
        ///<summary>Solid Caret Square Right</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-right?style=solid"/>
        [Description("Solid Caret Square Right"), IconID("fas-caret-square-right")]
        SolidCaretSquareRight = 0xf152,
        ///<summary>Solid Caret Square Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-square-up?style=solid"/>
        [Description("Solid Caret Square Up"), IconID("fas-caret-square-up")]
        SolidCaretSquareUp = 0xf151,
        ///<summary>Solid Caret Up</summary>
        ///<see href="https://fontawesome.com/icons/caret-up?style=solid"/>
        [Description("Solid Caret Up"), IconID("fas-caret-up")]
        SolidCaretUp = 0xf0d8,
        ///<summary>Solid Carrot</summary>
        ///<see href="https://fontawesome.com/icons/carrot?style=solid"/>
        [Description("Solid Carrot"), IconID("fas-carrot")]
        SolidCarrot = 0xf787,
        ///<summary>Solid Cart Arrow Down</summary>
        ///<see href="https://fontawesome.com/icons/cart-arrow-down?style=solid"/>
        [Description("Solid Cart Arrow Down"), IconID("fas-cart-arrow-down")]
        SolidCartArrowDown = 0xf218,
        ///<summary>Solid Cart Plus</summary>
        ///<see href="https://fontawesome.com/icons/cart-plus?style=solid"/>
        [Description("Solid Cart Plus"), IconID("fas-cart-plus")]
        SolidCartPlus = 0xf217,
        ///<summary>Solid Cash Register</summary>
        ///<see href="https://fontawesome.com/icons/cash-register?style=solid"/>
        [Description("Solid Cash Register"), IconID("fas-cash-register")]
        SolidCashRegister = 0xf788,
        ///<summary>Solid Cat</summary>
        ///<see href="https://fontawesome.com/icons/cat?style=solid"/>
        [Description("Solid Cat"), IconID("fas-cat")]
        SolidCat = 0xf6be,
        ///<summary>Solid Certificate</summary>
        ///<see href="https://fontawesome.com/icons/certificate?style=solid"/>
        [Description("Solid Certificate"), IconID("fas-certificate")]
        SolidCertificate = 0xf0a3,
        ///<summary>Solid Chair</summary>
        ///<see href="https://fontawesome.com/icons/chair?style=solid"/>
        [Description("Solid Chair"), IconID("fas-chair")]
        SolidChair = 0xf6c0,
        ///<summary>Solid Chalkboard</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard?style=solid"/>
        [Description("Solid Chalkboard"), IconID("fas-chalkboard")]
        SolidChalkboard = 0xf51b,
        ///<summary>Solid Chalkboard Teacher</summary>
        ///<see href="https://fontawesome.com/icons/chalkboard-teacher?style=solid"/>
        [Description("Solid Chalkboard Teacher"), IconID("fas-chalkboard-teacher")]
        SolidChalkboardTeacher = 0xf51c,
        ///<summary>Solid Charging Station</summary>
        ///<see href="https://fontawesome.com/icons/charging-station?style=solid"/>
        [Description("Solid Charging Station"), IconID("fas-charging-station")]
        SolidChargingStation = 0xf5e7,
        ///<summary>Solid Chart Area</summary>
        ///<see href="https://fontawesome.com/icons/chart-area?style=solid"/>
        [Description("Solid Chart Area"), IconID("fas-chart-area")]
        SolidChartArea = 0xf1fe,
        ///<summary>Solid Chart Bar</summary>
        ///<see href="https://fontawesome.com/icons/chart-bar?style=solid"/>
        [Description("Solid Chart Bar"), IconID("fas-chart-bar")]
        SolidChartBar = 0xf080,
        ///<summary>Solid Chart Line</summary>
        ///<see href="https://fontawesome.com/icons/chart-line?style=solid"/>
        [Description("Solid Chart Line"), IconID("fas-chart-line")]
        SolidChartLine = 0xf201,
        ///<summary>Solid Chart Pie</summary>
        ///<see href="https://fontawesome.com/icons/chart-pie?style=solid"/>
        [Description("Solid Chart Pie"), IconID("fas-chart-pie")]
        SolidChartPie = 0xf200,
        ///<summary>Solid Check</summary>
        ///<see href="https://fontawesome.com/icons/check?style=solid"/>
        [Description("Solid Check"), IconID("fas-check")]
        SolidCheck = 0xf00c,
        ///<summary>Solid Check Circle</summary>
        ///<see href="https://fontawesome.com/icons/check-circle?style=solid"/>
        [Description("Solid Check Circle"), IconID("fas-check-circle")]
        SolidCheckCircle = 0xf058,
        ///<summary>Solid Check Double</summary>
        ///<see href="https://fontawesome.com/icons/check-double?style=solid"/>
        [Description("Solid Check Double"), IconID("fas-check-double")]
        SolidCheckDouble = 0xf560,
        ///<summary>Solid Check Square</summary>
        ///<see href="https://fontawesome.com/icons/check-square?style=solid"/>
        [Description("Solid Check Square"), IconID("fas-check-square")]
        SolidCheckSquare = 0xf14a,
        ///<summary>Solid Cheese</summary>
        ///<see href="https://fontawesome.com/icons/cheese?style=solid"/>
        [Description("Solid Cheese"), IconID("fas-cheese")]
        SolidCheese = 0xf7ef,
        ///<summary>Solid Chess</summary>
        ///<see href="https://fontawesome.com/icons/chess?style=solid"/>
        [Description("Solid Chess"), IconID("fas-chess")]
        SolidChess = 0xf439,
        ///<summary>Solid Chess Bishop</summary>
        ///<see href="https://fontawesome.com/icons/chess-bishop?style=solid"/>
        [Description("Solid Chess Bishop"), IconID("fas-chess-bishop")]
        SolidChessBishop = 0xf43a,
        ///<summary>Solid Chess Board</summary>
        ///<see href="https://fontawesome.com/icons/chess-board?style=solid"/>
        [Description("Solid Chess Board"), IconID("fas-chess-board")]
        SolidChessBoard = 0xf43c,
        ///<summary>Solid Chess King</summary>
        ///<see href="https://fontawesome.com/icons/chess-king?style=solid"/>
        [Description("Solid Chess King"), IconID("fas-chess-king")]
        SolidChessKing = 0xf43f,
        ///<summary>Solid Chess Knight</summary>
        ///<see href="https://fontawesome.com/icons/chess-knight?style=solid"/>
        [Description("Solid Chess Knight"), IconID("fas-chess-knight")]
        SolidChessKnight = 0xf441,
        ///<summary>Solid Chess Pawn</summary>
        ///<see href="https://fontawesome.com/icons/chess-pawn?style=solid"/>
        [Description("Solid Chess Pawn"), IconID("fas-chess-pawn")]
        SolidChessPawn = 0xf443,
        ///<summary>Solid Chess Queen</summary>
        ///<see href="https://fontawesome.com/icons/chess-queen?style=solid"/>
        [Description("Solid Chess Queen"), IconID("fas-chess-queen")]
        SolidChessQueen = 0xf445,
        ///<summary>Solid Chess Rook</summary>
        ///<see href="https://fontawesome.com/icons/chess-rook?style=solid"/>
        [Description("Solid Chess Rook"), IconID("fas-chess-rook")]
        SolidChessRook = 0xf447,
        ///<summary>Solid Chevron Circle Down</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-down?style=solid"/>
        [Description("Solid Chevron Circle Down"), IconID("fas-chevron-circle-down")]
        SolidChevronCircleDown = 0xf13a,
        ///<summary>Solid Chevron Circle Left</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-left?style=solid"/>
        [Description("Solid Chevron Circle Left"), IconID("fas-chevron-circle-left")]
        SolidChevronCircleLeft = 0xf137,
        ///<summary>Solid Chevron Circle Right</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-right?style=solid"/>
        [Description("Solid Chevron Circle Right"), IconID("fas-chevron-circle-right")]
        SolidChevronCircleRight = 0xf138,
        ///<summary>Solid Chevron Circle Up</summary>
        ///<see href="https://fontawesome.com/icons/chevron-circle-up?style=solid"/>
        [Description("Solid Chevron Circle Up"), IconID("fas-chevron-circle-up")]
        SolidChevronCircleUp = 0xf139,
        ///<summary>Solid Chevron Down</summary>
        ///<see href="https://fontawesome.com/icons/chevron-down?style=solid"/>
        [Description("Solid Chevron Down"), IconID("fas-chevron-down")]
        SolidChevronDown = 0xf078,
        ///<summary>Solid Chevron Left</summary>
        ///<see href="https://fontawesome.com/icons/chevron-left?style=solid"/>
        [Description("Solid Chevron Left"), IconID("fas-chevron-left")]
        SolidChevronLeft = 0xf053,
        ///<summary>Solid Chevron Right</summary>
        ///<see href="https://fontawesome.com/icons/chevron-right?style=solid"/>
        [Description("Solid Chevron Right"), IconID("fas-chevron-right")]
        SolidChevronRight = 0xf054,
        ///<summary>Solid Chevron Up</summary>
        ///<see href="https://fontawesome.com/icons/chevron-up?style=solid"/>
        [Description("Solid Chevron Up"), IconID("fas-chevron-up")]
        SolidChevronUp = 0xf077,
        ///<summary>Solid Child</summary>
        ///<see href="https://fontawesome.com/icons/child?style=solid"/>
        [Description("Solid Child"), IconID("fas-child")]
        SolidChild = 0xf1ae,
        ///<summary>Solid Church</summary>
        ///<see href="https://fontawesome.com/icons/church?style=solid"/>
        [Description("Solid Church"), IconID("fas-church")]
        SolidChurch = 0xf51d,
        ///<summary>Solid Circle</summary>
        ///<see href="https://fontawesome.com/icons/circle?style=solid"/>
        [Description("Solid Circle"), IconID("fas-circle")]
        SolidCircle = 0xf111,
        ///<summary>Solid Circle Notch</summary>
        ///<see href="https://fontawesome.com/icons/circle-notch?style=solid"/>
        [Description("Solid Circle Notch"), IconID("fas-circle-notch")]
        SolidCircleNotch = 0xf1ce,
        ///<summary>Solid City</summary>
        ///<see href="https://fontawesome.com/icons/city?style=solid"/>
        [Description("Solid City"), IconID("fas-city")]
        SolidCity = 0xf64f,
        ///<summary>Solid Clinic Medical</summary>
        ///<see href="https://fontawesome.com/icons/clinic-medical?style=solid"/>
        [Description("Solid Clinic Medical"), IconID("fas-clinic-medical")]
        SolidClinicMedical = 0xf7f2,
        ///<summary>Solid Clipboard</summary>
        ///<see href="https://fontawesome.com/icons/clipboard?style=solid"/>
        [Description("Solid Clipboard"), IconID("fas-clipboard")]
        SolidClipboard = 0xf328,
        ///<summary>Solid Clipboard Check</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-check?style=solid"/>
        [Description("Solid Clipboard Check"), IconID("fas-clipboard-check")]
        SolidClipboardCheck = 0xf46c,
        ///<summary>Solid Clipboard List</summary>
        ///<see href="https://fontawesome.com/icons/clipboard-list?style=solid"/>
        [Description("Solid Clipboard List"), IconID("fas-clipboard-list")]
        SolidClipboardList = 0xf46d,
        ///<summary>Solid Clock</summary>
        ///<see href="https://fontawesome.com/icons/clock?style=solid"/>
        [Description("Solid Clock"), IconID("fas-clock")]
        SolidClock = 0xf017,
        ///<summary>Solid Clone</summary>
        ///<see href="https://fontawesome.com/icons/clone?style=solid"/>
        [Description("Solid Clone"), IconID("fas-clone")]
        SolidClone = 0xf24d,
        ///<summary>Solid Closed Captioning</summary>
        ///<see href="https://fontawesome.com/icons/closed-captioning?style=solid"/>
        [Description("Solid Closed Captioning"), IconID("fas-closed-captioning")]
        SolidClosedCaptioning = 0xf20a,
        ///<summary>Solid Cloud</summary>
        ///<see href="https://fontawesome.com/icons/cloud?style=solid"/>
        [Description("Solid Cloud"), IconID("fas-cloud")]
        SolidCloud = 0xf0c2,
        ///<summary>Solid Cloud Download Alt</summary>
        ///<see href="https://fontawesome.com/icons/cloud-download-alt?style=solid"/>
        [Description("Solid Cloud Download Alt"), IconID("fas-cloud-download-alt")]
        SolidCloudDownloadAlt = 0xf381,
        ///<summary>Solid Cloud Meatball</summary>
        ///<see href="https://fontawesome.com/icons/cloud-meatball?style=solid"/>
        [Description("Solid Cloud Meatball"), IconID("fas-cloud-meatball")]
        SolidCloudMeatball = 0xf73b,
        ///<summary>Solid Cloud Moon</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon?style=solid"/>
        [Description("Solid Cloud Moon"), IconID("fas-cloud-moon")]
        SolidCloudMoon = 0xf6c3,
        ///<summary>Solid Cloud Moon Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-moon-rain?style=solid"/>
        [Description("Solid Cloud Moon Rain"), IconID("fas-cloud-moon-rain")]
        SolidCloudMoonRain = 0xf73c,
        ///<summary>Solid Cloud Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-rain?style=solid"/>
        [Description("Solid Cloud Rain"), IconID("fas-cloud-rain")]
        SolidCloudRain = 0xf73d,
        ///<summary>Solid Cloud Showers Heavy</summary>
        ///<see href="https://fontawesome.com/icons/cloud-showers-heavy?style=solid"/>
        [Description("Solid Cloud Showers Heavy"), IconID("fas-cloud-showers-heavy")]
        SolidCloudShowersHeavy = 0xf740,
        ///<summary>Solid Cloud Sun</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun?style=solid"/>
        [Description("Solid Cloud Sun"), IconID("fas-cloud-sun")]
        SolidCloudSun = 0xf6c4,
        ///<summary>Solid Cloud Sun Rain</summary>
        ///<see href="https://fontawesome.com/icons/cloud-sun-rain?style=solid"/>
        [Description("Solid Cloud Sun Rain"), IconID("fas-cloud-sun-rain")]
        SolidCloudSunRain = 0xf743,
        ///<summary>Solid Cloud Upload Alt</summary>
        ///<see href="https://fontawesome.com/icons/cloud-upload-alt?style=solid"/>
        [Description("Solid Cloud Upload Alt"), IconID("fas-cloud-upload-alt")]
        SolidCloudUploadAlt = 0xf382,
        ///<summary>Solid Cocktail</summary>
        ///<see href="https://fontawesome.com/icons/cocktail?style=solid"/>
        [Description("Solid Cocktail"), IconID("fas-cocktail")]
        SolidCocktail = 0xf561,
        ///<summary>Solid Code</summary>
        ///<see href="https://fontawesome.com/icons/code?style=solid"/>
        [Description("Solid Code"), IconID("fas-code")]
        SolidCode = 0xf121,
        ///<summary>Solid Code Branch</summary>
        ///<see href="https://fontawesome.com/icons/code-branch?style=solid"/>
        [Description("Solid Code Branch"), IconID("fas-code-branch")]
        SolidCodeBranch = 0xf126,
        ///<summary>Solid Coffee</summary>
        ///<see href="https://fontawesome.com/icons/coffee?style=solid"/>
        [Description("Solid Coffee"), IconID("fas-coffee")]
        SolidCoffee = 0xf0f4,
        ///<summary>Solid Cog</summary>
        ///<see href="https://fontawesome.com/icons/cog?style=solid"/>
        [Description("Solid Cog"), IconID("fas-cog")]
        SolidCog = 0xf013,
        ///<summary>Solid Cogs</summary>
        ///<see href="https://fontawesome.com/icons/cogs?style=solid"/>
        [Description("Solid Cogs"), IconID("fas-cogs")]
        SolidCogs = 0xf085,
        ///<summary>Solid Coins</summary>
        ///<see href="https://fontawesome.com/icons/coins?style=solid"/>
        [Description("Solid Coins"), IconID("fas-coins")]
        SolidCoins = 0xf51e,
        ///<summary>Solid Columns</summary>
        ///<see href="https://fontawesome.com/icons/columns?style=solid"/>
        [Description("Solid Columns"), IconID("fas-columns")]
        SolidColumns = 0xf0db,
        ///<summary>Solid Comment</summary>
        ///<see href="https://fontawesome.com/icons/comment?style=solid"/>
        [Description("Solid Comment"), IconID("fas-comment")]
        SolidComment = 0xf075,
        ///<summary>Solid Comment Alt</summary>
        ///<see href="https://fontawesome.com/icons/comment-alt?style=solid"/>
        [Description("Solid Comment Alt"), IconID("fas-comment-alt")]
        SolidCommentAlt = 0xf27a,
        ///<summary>Solid Comment Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comment-dollar?style=solid"/>
        [Description("Solid Comment Dollar"), IconID("fas-comment-dollar")]
        SolidCommentDollar = 0xf651,
        ///<summary>Solid Comment Dots</summary>
        ///<see href="https://fontawesome.com/icons/comment-dots?style=solid"/>
        [Description("Solid Comment Dots"), IconID("fas-comment-dots")]
        SolidCommentDots = 0xf4ad,
        ///<summary>Solid Comment Medical</summary>
        ///<see href="https://fontawesome.com/icons/comment-medical?style=solid"/>
        [Description("Solid Comment Medical"), IconID("fas-comment-medical")]
        SolidCommentMedical = 0xf7f5,
        ///<summary>Solid Comment Slash</summary>
        ///<see href="https://fontawesome.com/icons/comment-slash?style=solid"/>
        [Description("Solid Comment Slash"), IconID("fas-comment-slash")]
        SolidCommentSlash = 0xf4b3,
        ///<summary>Solid Comments</summary>
        ///<see href="https://fontawesome.com/icons/comments?style=solid"/>
        [Description("Solid Comments"), IconID("fas-comments")]
        SolidComments = 0xf086,
        ///<summary>Solid Comments Dollar</summary>
        ///<see href="https://fontawesome.com/icons/comments-dollar?style=solid"/>
        [Description("Solid Comments Dollar"), IconID("fas-comments-dollar")]
        SolidCommentsDollar = 0xf653,
        ///<summary>Solid Compact Disc</summary>
        ///<see href="https://fontawesome.com/icons/compact-disc?style=solid"/>
        [Description("Solid Compact Disc"), IconID("fas-compact-disc")]
        SolidCompactDisc = 0xf51f,
        ///<summary>Solid Compass</summary>
        ///<see href="https://fontawesome.com/icons/compass?style=solid"/>
        [Description("Solid Compass"), IconID("fas-compass")]
        SolidCompass = 0xf14e,
        ///<summary>Solid Compress</summary>
        ///<see href="https://fontawesome.com/icons/compress?style=solid"/>
        [Description("Solid Compress"), IconID("fas-compress")]
        SolidCompress = 0xf066,
        ///<summary>Solid Compress Alt</summary>
        ///<see href="https://fontawesome.com/icons/compress-alt?style=solid"/>
        [Description("Solid Compress Alt"), IconID("fas-compress-alt")]
        SolidCompressAlt = 0xf422,
        ///<summary>Solid Compress Arrows Alt</summary>
        ///<see href="https://fontawesome.com/icons/compress-arrows-alt?style=solid"/>
        [Description("Solid Compress Arrows Alt"), IconID("fas-compress-arrows-alt")]
        SolidCompressArrowsAlt = 0xf78c,
        ///<summary>Solid Concierge Bell</summary>
        ///<see href="https://fontawesome.com/icons/concierge-bell?style=solid"/>
        [Description("Solid Concierge Bell"), IconID("fas-concierge-bell")]
        SolidConciergeBell = 0xf562,
        ///<summary>Solid Cookie</summary>
        ///<see href="https://fontawesome.com/icons/cookie?style=solid"/>
        [Description("Solid Cookie"), IconID("fas-cookie")]
        SolidCookie = 0xf563,
        ///<summary>Solid Cookie Bite</summary>
        ///<see href="https://fontawesome.com/icons/cookie-bite?style=solid"/>
        [Description("Solid Cookie Bite"), IconID("fas-cookie-bite")]
        SolidCookieBite = 0xf564,
        ///<summary>Solid Copy</summary>
        ///<see href="https://fontawesome.com/icons/copy?style=solid"/>
        [Description("Solid Copy"), IconID("fas-copy")]
        SolidCopy = 0xf0c5,
        ///<summary>Solid Copyright</summary>
        ///<see href="https://fontawesome.com/icons/copyright?style=solid"/>
        [Description("Solid Copyright"), IconID("fas-copyright")]
        SolidCopyright = 0xf1f9,
        ///<summary>Solid Couch</summary>
        ///<see href="https://fontawesome.com/icons/couch?style=solid"/>
        [Description("Solid Couch"), IconID("fas-couch")]
        SolidCouch = 0xf4b8,
        ///<summary>Solid Credit Card</summary>
        ///<see href="https://fontawesome.com/icons/credit-card?style=solid"/>
        [Description("Solid Credit Card"), IconID("fas-credit-card")]
        SolidCreditCard = 0xf09d,
        ///<summary>Solid Crop</summary>
        ///<see href="https://fontawesome.com/icons/crop?style=solid"/>
        [Description("Solid Crop"), IconID("fas-crop")]
        SolidCrop = 0xf125,
        ///<summary>Solid Crop Alt</summary>
        ///<see href="https://fontawesome.com/icons/crop-alt?style=solid"/>
        [Description("Solid Crop Alt"), IconID("fas-crop-alt")]
        SolidCropAlt = 0xf565,
        ///<summary>Solid Cross</summary>
        ///<see href="https://fontawesome.com/icons/cross?style=solid"/>
        [Description("Solid Cross"), IconID("fas-cross")]
        SolidCross = 0xf654,
        ///<summary>Solid Crosshairs</summary>
        ///<see href="https://fontawesome.com/icons/crosshairs?style=solid"/>
        [Description("Solid Crosshairs"), IconID("fas-crosshairs")]
        SolidCrosshairs = 0xf05b,
        ///<summary>Solid Crow</summary>
        ///<see href="https://fontawesome.com/icons/crow?style=solid"/>
        [Description("Solid Crow"), IconID("fas-crow")]
        SolidCrow = 0xf520,
        ///<summary>Solid Crown</summary>
        ///<see href="https://fontawesome.com/icons/crown?style=solid"/>
        [Description("Solid Crown"), IconID("fas-crown")]
        SolidCrown = 0xf521,
        ///<summary>Solid Crutch</summary>
        ///<see href="https://fontawesome.com/icons/crutch?style=solid"/>
        [Description("Solid Crutch"), IconID("fas-crutch")]
        SolidCrutch = 0xf7f7,
        ///<summary>Solid Cube</summary>
        ///<see href="https://fontawesome.com/icons/cube?style=solid"/>
        [Description("Solid Cube"), IconID("fas-cube")]
        SolidCube = 0xf1b2,
        ///<summary>Solid Cubes</summary>
        ///<see href="https://fontawesome.com/icons/cubes?style=solid"/>
        [Description("Solid Cubes"), IconID("fas-cubes")]
        SolidCubes = 0xf1b3,
        ///<summary>Solid Cut</summary>
        ///<see href="https://fontawesome.com/icons/cut?style=solid"/>
        [Description("Solid Cut"), IconID("fas-cut")]
        SolidCut = 0xf0c4,
        ///<summary>Solid Database</summary>
        ///<see href="https://fontawesome.com/icons/database?style=solid"/>
        [Description("Solid Database"), IconID("fas-database")]
        SolidDatabase = 0xf1c0,
        ///<summary>Solid Deaf</summary>
        ///<see href="https://fontawesome.com/icons/deaf?style=solid"/>
        [Description("Solid Deaf"), IconID("fas-deaf")]
        SolidDeaf = 0xf2a4,
        ///<summary>Solid Democrat</summary>
        ///<see href="https://fontawesome.com/icons/democrat?style=solid"/>
        [Description("Solid Democrat"), IconID("fas-democrat")]
        SolidDemocrat = 0xf747,
        ///<summary>Solid Desktop</summary>
        ///<see href="https://fontawesome.com/icons/desktop?style=solid"/>
        [Description("Solid Desktop"), IconID("fas-desktop")]
        SolidDesktop = 0xf108,
        ///<summary>Solid Dharmachakra</summary>
        ///<see href="https://fontawesome.com/icons/dharmachakra?style=solid"/>
        [Description("Solid Dharmachakra"), IconID("fas-dharmachakra")]
        SolidDharmachakra = 0xf655,
        ///<summary>Solid Diagnoses</summary>
        ///<see href="https://fontawesome.com/icons/diagnoses?style=solid"/>
        [Description("Solid Diagnoses"), IconID("fas-diagnoses")]
        SolidDiagnoses = 0xf470,
        ///<summary>Solid Dice</summary>
        ///<see href="https://fontawesome.com/icons/dice?style=solid"/>
        [Description("Solid Dice"), IconID("fas-dice")]
        SolidDice = 0xf522,
        ///<summary>Solid Dice D20</summary>
        ///<see href="https://fontawesome.com/icons/dice-d20?style=solid"/>
        [Description("Solid Dice D20"), IconID("fas-dice-d20")]
        SolidDiceD20 = 0xf6cf,
        ///<summary>Solid Dice D6</summary>
        ///<see href="https://fontawesome.com/icons/dice-d6?style=solid"/>
        [Description("Solid Dice D6"), IconID("fas-dice-d6")]
        SolidDiceD6 = 0xf6d1,
        ///<summary>Solid Dice Five</summary>
        ///<see href="https://fontawesome.com/icons/dice-five?style=solid"/>
        [Description("Solid Dice Five"), IconID("fas-dice-five")]
        SolidDiceFive = 0xf523,
        ///<summary>Solid Dice Four</summary>
        ///<see href="https://fontawesome.com/icons/dice-four?style=solid"/>
        [Description("Solid Dice Four"), IconID("fas-dice-four")]
        SolidDiceFour = 0xf524,
        ///<summary>Solid Dice One</summary>
        ///<see href="https://fontawesome.com/icons/dice-one?style=solid"/>
        [Description("Solid Dice One"), IconID("fas-dice-one")]
        SolidDiceOne = 0xf525,
        ///<summary>Solid Dice Six</summary>
        ///<see href="https://fontawesome.com/icons/dice-six?style=solid"/>
        [Description("Solid Dice Six"), IconID("fas-dice-six")]
        SolidDiceSix = 0xf526,
        ///<summary>Solid Dice Three</summary>
        ///<see href="https://fontawesome.com/icons/dice-three?style=solid"/>
        [Description("Solid Dice Three"), IconID("fas-dice-three")]
        SolidDiceThree = 0xf527,
        ///<summary>Solid Dice Two</summary>
        ///<see href="https://fontawesome.com/icons/dice-two?style=solid"/>
        [Description("Solid Dice Two"), IconID("fas-dice-two")]
        SolidDiceTwo = 0xf528,
        ///<summary>Solid Digital Tachograph</summary>
        ///<see href="https://fontawesome.com/icons/digital-tachograph?style=solid"/>
        [Description("Solid Digital Tachograph"), IconID("fas-digital-tachograph")]
        SolidDigitalTachograph = 0xf566,
        ///<summary>Solid Directions</summary>
        ///<see href="https://fontawesome.com/icons/directions?style=solid"/>
        [Description("Solid Directions"), IconID("fas-directions")]
        SolidDirections = 0xf5eb,
        ///<summary>Solid Disease</summary>
        ///<see href="https://fontawesome.com/icons/disease?style=solid"/>
        [Description("Solid Disease"), IconID("fas-disease")]
        SolidDisease = 0xf7fa,
        ///<summary>Solid Divide</summary>
        ///<see href="https://fontawesome.com/icons/divide?style=solid"/>
        [Description("Solid Divide"), IconID("fas-divide")]
        SolidDivide = 0xf529,
        ///<summary>Solid Dizzy</summary>
        ///<see href="https://fontawesome.com/icons/dizzy?style=solid"/>
        [Description("Solid Dizzy"), IconID("fas-dizzy")]
        SolidDizzy = 0xf567,
        ///<summary>Solid Dna</summary>
        ///<see href="https://fontawesome.com/icons/dna?style=solid"/>
        [Description("Solid Dna"), IconID("fas-dna")]
        SolidDna = 0xf471,
        ///<summary>Solid Dog</summary>
        ///<see href="https://fontawesome.com/icons/dog?style=solid"/>
        [Description("Solid Dog"), IconID("fas-dog")]
        SolidDog = 0xf6d3,
        ///<summary>Solid Dollar Sign</summary>
        ///<see href="https://fontawesome.com/icons/dollar-sign?style=solid"/>
        [Description("Solid Dollar Sign"), IconID("fas-dollar-sign")]
        SolidDollarSign = 0xf155,
        ///<summary>Solid Dolly</summary>
        ///<see href="https://fontawesome.com/icons/dolly?style=solid"/>
        [Description("Solid Dolly"), IconID("fas-dolly")]
        SolidDolly = 0xf472,
        ///<summary>Solid Dolly Flatbed</summary>
        ///<see href="https://fontawesome.com/icons/dolly-flatbed?style=solid"/>
        [Description("Solid Dolly Flatbed"), IconID("fas-dolly-flatbed")]
        SolidDollyFlatbed = 0xf474,
        ///<summary>Solid Donate</summary>
        ///<see href="https://fontawesome.com/icons/donate?style=solid"/>
        [Description("Solid Donate"), IconID("fas-donate")]
        SolidDonate = 0xf4b9,
        ///<summary>Solid Door Closed</summary>
        ///<see href="https://fontawesome.com/icons/door-closed?style=solid"/>
        [Description("Solid Door Closed"), IconID("fas-door-closed")]
        SolidDoorClosed = 0xf52a,
        ///<summary>Solid Door Open</summary>
        ///<see href="https://fontawesome.com/icons/door-open?style=solid"/>
        [Description("Solid Door Open"), IconID("fas-door-open")]
        SolidDoorOpen = 0xf52b,
        ///<summary>Solid Dot Circle</summary>
        ///<see href="https://fontawesome.com/icons/dot-circle?style=solid"/>
        [Description("Solid Dot Circle"), IconID("fas-dot-circle")]
        SolidDotCircle = 0xf192,
        ///<summary>Solid Dove</summary>
        ///<see href="https://fontawesome.com/icons/dove?style=solid"/>
        [Description("Solid Dove"), IconID("fas-dove")]
        SolidDove = 0xf4ba,
        ///<summary>Solid Download</summary>
        ///<see href="https://fontawesome.com/icons/download?style=solid"/>
        [Description("Solid Download"), IconID("fas-download")]
        SolidDownload = 0xf019,
        ///<summary>Solid Drafting Compass</summary>
        ///<see href="https://fontawesome.com/icons/drafting-compass?style=solid"/>
        [Description("Solid Drafting Compass"), IconID("fas-drafting-compass")]
        SolidDraftingCompass = 0xf568,
        ///<summary>Solid Dragon</summary>
        ///<see href="https://fontawesome.com/icons/dragon?style=solid"/>
        [Description("Solid Dragon"), IconID("fas-dragon")]
        SolidDragon = 0xf6d5,
        ///<summary>Solid Draw Polygon</summary>
        ///<see href="https://fontawesome.com/icons/draw-polygon?style=solid"/>
        [Description("Solid Draw Polygon"), IconID("fas-draw-polygon")]
        SolidDrawPolygon = 0xf5ee,
        ///<summary>Solid Drum</summary>
        ///<see href="https://fontawesome.com/icons/drum?style=solid"/>
        [Description("Solid Drum"), IconID("fas-drum")]
        SolidDrum = 0xf569,
        ///<summary>Solid Drum Steelpan</summary>
        ///<see href="https://fontawesome.com/icons/drum-steelpan?style=solid"/>
        [Description("Solid Drum Steelpan"), IconID("fas-drum-steelpan")]
        SolidDrumSteelpan = 0xf56a,
        ///<summary>Solid Drumstick Bite</summary>
        ///<see href="https://fontawesome.com/icons/drumstick-bite?style=solid"/>
        [Description("Solid Drumstick Bite"), IconID("fas-drumstick-bite")]
        SolidDrumstickBite = 0xf6d7,
        ///<summary>Solid Dumbbell</summary>
        ///<see href="https://fontawesome.com/icons/dumbbell?style=solid"/>
        [Description("Solid Dumbbell"), IconID("fas-dumbbell")]
        SolidDumbbell = 0xf44b,
        ///<summary>Solid Dumpster</summary>
        ///<see href="https://fontawesome.com/icons/dumpster?style=solid"/>
        [Description("Solid Dumpster"), IconID("fas-dumpster")]
        SolidDumpster = 0xf793,
        ///<summary>Solid Dumpster Fire</summary>
        ///<see href="https://fontawesome.com/icons/dumpster-fire?style=solid"/>
        [Description("Solid Dumpster Fire"), IconID("fas-dumpster-fire")]
        SolidDumpsterFire = 0xf794,
        ///<summary>Solid Dungeon</summary>
        ///<see href="https://fontawesome.com/icons/dungeon?style=solid"/>
        [Description("Solid Dungeon"), IconID("fas-dungeon")]
        SolidDungeon = 0xf6d9,
        ///<summary>Solid Edit</summary>
        ///<see href="https://fontawesome.com/icons/edit?style=solid"/>
        [Description("Solid Edit"), IconID("fas-edit")]
        SolidEdit = 0xf044,
        ///<summary>Solid Egg</summary>
        ///<see href="https://fontawesome.com/icons/egg?style=solid"/>
        [Description("Solid Egg"), IconID("fas-egg")]
        SolidEgg = 0xf7fb,
        ///<summary>Solid Eject</summary>
        ///<see href="https://fontawesome.com/icons/eject?style=solid"/>
        [Description("Solid Eject"), IconID("fas-eject")]
        SolidEject = 0xf052,
        ///<summary>Solid Ellipsis H</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis-h?style=solid"/>
        [Description("Solid Ellipsis H"), IconID("fas-ellipsis-h")]
        SolidEllipsisH = 0xf141,
        ///<summary>Solid Ellipsis V</summary>
        ///<see href="https://fontawesome.com/icons/ellipsis-v?style=solid"/>
        [Description("Solid Ellipsis V"), IconID("fas-ellipsis-v")]
        SolidEllipsisV = 0xf142,
        ///<summary>Solid Envelope</summary>
        ///<see href="https://fontawesome.com/icons/envelope?style=solid"/>
        [Description("Solid Envelope"), IconID("fas-envelope")]
        SolidEnvelope = 0xf0e0,
        ///<summary>Solid Envelope Open</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open?style=solid"/>
        [Description("Solid Envelope Open"), IconID("fas-envelope-open")]
        SolidEnvelopeOpen = 0xf2b6,
        ///<summary>Solid Envelope Open Text</summary>
        ///<see href="https://fontawesome.com/icons/envelope-open-text?style=solid"/>
        [Description("Solid Envelope Open Text"), IconID("fas-envelope-open-text")]
        SolidEnvelopeOpenText = 0xf658,
        ///<summary>Solid Envelope Square</summary>
        ///<see href="https://fontawesome.com/icons/envelope-square?style=solid"/>
        [Description("Solid Envelope Square"), IconID("fas-envelope-square")]
        SolidEnvelopeSquare = 0xf199,
        ///<summary>Solid Equals</summary>
        ///<see href="https://fontawesome.com/icons/equals?style=solid"/>
        [Description("Solid Equals"), IconID("fas-equals")]
        SolidEquals = 0xf52c,
        ///<summary>Solid Eraser</summary>
        ///<see href="https://fontawesome.com/icons/eraser?style=solid"/>
        [Description("Solid Eraser"), IconID("fas-eraser")]
        SolidEraser = 0xf12d,
        ///<summary>Solid Ethernet</summary>
        ///<see href="https://fontawesome.com/icons/ethernet?style=solid"/>
        [Description("Solid Ethernet"), IconID("fas-ethernet")]
        SolidEthernet = 0xf796,
        ///<summary>Solid Euro Sign</summary>
        ///<see href="https://fontawesome.com/icons/euro-sign?style=solid"/>
        [Description("Solid Euro Sign"), IconID("fas-euro-sign")]
        SolidEuroSign = 0xf153,
        ///<summary>Solid Exchange Alt</summary>
        ///<see href="https://fontawesome.com/icons/exchange-alt?style=solid"/>
        [Description("Solid Exchange Alt"), IconID("fas-exchange-alt")]
        SolidExchangeAlt = 0xf362,
        ///<summary>Solid Exclamation</summary>
        ///<see href="https://fontawesome.com/icons/exclamation?style=solid"/>
        [Description("Solid Exclamation"), IconID("fas-exclamation")]
        SolidExclamation = 0xf12a,
        ///<summary>Solid Exclamation Circle</summary>
        ///<see href="https://fontawesome.com/icons/exclamation-circle?style=solid"/>
        [Description("Solid Exclamation Circle"), IconID("fas-exclamation-circle")]
        SolidExclamationCircle = 0xf06a,
        ///<summary>Solid Exclamation Triangle</summary>
        ///<see href="https://fontawesome.com/icons/exclamation-triangle?style=solid"/>
        [Description("Solid Exclamation Triangle"), IconID("fas-exclamation-triangle")]
        SolidExclamationTriangle = 0xf071,
        ///<summary>Solid Expand</summary>
        ///<see href="https://fontawesome.com/icons/expand?style=solid"/>
        [Description("Solid Expand"), IconID("fas-expand")]
        SolidExpand = 0xf065,
        ///<summary>Solid Expand Alt</summary>
        ///<see href="https://fontawesome.com/icons/expand-alt?style=solid"/>
        [Description("Solid Expand Alt"), IconID("fas-expand-alt")]
        SolidExpandAlt = 0xf424,
        ///<summary>Solid Expand Arrows Alt</summary>
        ///<see href="https://fontawesome.com/icons/expand-arrows-alt?style=solid"/>
        [Description("Solid Expand Arrows Alt"), IconID("fas-expand-arrows-alt")]
        SolidExpandArrowsAlt = 0xf31e,
        ///<summary>Solid External Link Alt</summary>
        ///<see href="https://fontawesome.com/icons/external-link-alt?style=solid"/>
        [Description("Solid External Link Alt"), IconID("fas-external-link-alt")]
        SolidExternalLinkAlt = 0xf35d,
        ///<summary>Solid External Link Square Alt</summary>
        ///<see href="https://fontawesome.com/icons/external-link-square-alt?style=solid"/>
        [Description("Solid External Link Square Alt"), IconID("fas-external-link-square-alt")]
        SolidExternalLinkSquareAlt = 0xf360,
        ///<summary>Solid Eye</summary>
        ///<see href="https://fontawesome.com/icons/eye?style=solid"/>
        [Description("Solid Eye"), IconID("fas-eye")]
        SolidEye = 0xf06e,
        ///<summary>Solid Eye Dropper</summary>
        ///<see href="https://fontawesome.com/icons/eye-dropper?style=solid"/>
        [Description("Solid Eye Dropper"), IconID("fas-eye-dropper")]
        SolidEyeDropper = 0xf1fb,
        ///<summary>Solid Eye Slash</summary>
        ///<see href="https://fontawesome.com/icons/eye-slash?style=solid"/>
        [Description("Solid Eye Slash"), IconID("fas-eye-slash")]
        SolidEyeSlash = 0xf070,
        ///<summary>Solid Fan</summary>
        ///<see href="https://fontawesome.com/icons/fan?style=solid"/>
        [Description("Solid Fan"), IconID("fas-fan")]
        SolidFan = 0xf863,
        ///<summary>Solid Fast Backward</summary>
        ///<see href="https://fontawesome.com/icons/fast-backward?style=solid"/>
        [Description("Solid Fast Backward"), IconID("fas-fast-backward")]
        SolidFastBackward = 0xf049,
        ///<summary>Solid Fast Forward</summary>
        ///<see href="https://fontawesome.com/icons/fast-forward?style=solid"/>
        [Description("Solid Fast Forward"), IconID("fas-fast-forward")]
        SolidFastForward = 0xf050,
        ///<summary>Solid Faucet</summary>
        ///<see href="https://fontawesome.com/icons/faucet?style=solid"/>
        [Description("Solid Faucet"), IconID("fas-faucet")]
        SolidFaucet = 0xe005,
        ///<summary>Solid Fax</summary>
        ///<see href="https://fontawesome.com/icons/fax?style=solid"/>
        [Description("Solid Fax"), IconID("fas-fax")]
        SolidFax = 0xf1ac,
        ///<summary>Solid Feather</summary>
        ///<see href="https://fontawesome.com/icons/feather?style=solid"/>
        [Description("Solid Feather"), IconID("fas-feather")]
        SolidFeather = 0xf52d,
        ///<summary>Solid Feather Alt</summary>
        ///<see href="https://fontawesome.com/icons/feather-alt?style=solid"/>
        [Description("Solid Feather Alt"), IconID("fas-feather-alt")]
        SolidFeatherAlt = 0xf56b,
        ///<summary>Solid Female</summary>
        ///<see href="https://fontawesome.com/icons/female?style=solid"/>
        [Description("Solid Female"), IconID("fas-female")]
        SolidFemale = 0xf182,
        ///<summary>Solid Fighter Jet</summary>
        ///<see href="https://fontawesome.com/icons/fighter-jet?style=solid"/>
        [Description("Solid Fighter Jet"), IconID("fas-fighter-jet")]
        SolidFighterJet = 0xf0fb,
        ///<summary>Solid File</summary>
        ///<see href="https://fontawesome.com/icons/file?style=solid"/>
        [Description("Solid File"), IconID("fas-file")]
        SolidFile = 0xf15b,
        ///<summary>Solid File Alt</summary>
        ///<see href="https://fontawesome.com/icons/file-alt?style=solid"/>
        [Description("Solid File Alt"), IconID("fas-file-alt")]
        SolidFileAlt = 0xf15c,
        ///<summary>Solid File Archive</summary>
        ///<see href="https://fontawesome.com/icons/file-archive?style=solid"/>
        [Description("Solid File Archive"), IconID("fas-file-archive")]
        SolidFileArchive = 0xf1c6,
        ///<summary>Solid File Audio</summary>
        ///<see href="https://fontawesome.com/icons/file-audio?style=solid"/>
        [Description("Solid File Audio"), IconID("fas-file-audio")]
        SolidFileAudio = 0xf1c7,
        ///<summary>Solid File Code</summary>
        ///<see href="https://fontawesome.com/icons/file-code?style=solid"/>
        [Description("Solid File Code"), IconID("fas-file-code")]
        SolidFileCode = 0xf1c9,
        ///<summary>Solid File Contract</summary>
        ///<see href="https://fontawesome.com/icons/file-contract?style=solid"/>
        [Description("Solid File Contract"), IconID("fas-file-contract")]
        SolidFileContract = 0xf56c,
        ///<summary>Solid File Csv</summary>
        ///<see href="https://fontawesome.com/icons/file-csv?style=solid"/>
        [Description("Solid File Csv"), IconID("fas-file-csv")]
        SolidFileCsv = 0xf6dd,
        ///<summary>Solid File Download</summary>
        ///<see href="https://fontawesome.com/icons/file-download?style=solid"/>
        [Description("Solid File Download"), IconID("fas-file-download")]
        SolidFileDownload = 0xf56d,
        ///<summary>Solid File Excel</summary>
        ///<see href="https://fontawesome.com/icons/file-excel?style=solid"/>
        [Description("Solid File Excel"), IconID("fas-file-excel")]
        SolidFileExcel = 0xf1c3,
        ///<summary>Solid File Export</summary>
        ///<see href="https://fontawesome.com/icons/file-export?style=solid"/>
        [Description("Solid File Export"), IconID("fas-file-export")]
        SolidFileExport = 0xf56e,
        ///<summary>Solid File Image</summary>
        ///<see href="https://fontawesome.com/icons/file-image?style=solid"/>
        [Description("Solid File Image"), IconID("fas-file-image")]
        SolidFileImage = 0xf1c5,
        ///<summary>Solid File Import</summary>
        ///<see href="https://fontawesome.com/icons/file-import?style=solid"/>
        [Description("Solid File Import"), IconID("fas-file-import")]
        SolidFileImport = 0xf56f,
        ///<summary>Solid File Invoice</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice?style=solid"/>
        [Description("Solid File Invoice"), IconID("fas-file-invoice")]
        SolidFileInvoice = 0xf570,
        ///<summary>Solid File Invoice Dollar</summary>
        ///<see href="https://fontawesome.com/icons/file-invoice-dollar?style=solid"/>
        [Description("Solid File Invoice Dollar"), IconID("fas-file-invoice-dollar")]
        SolidFileInvoiceDollar = 0xf571,
        ///<summary>Solid File Medical</summary>
        ///<see href="https://fontawesome.com/icons/file-medical?style=solid"/>
        [Description("Solid File Medical"), IconID("fas-file-medical")]
        SolidFileMedical = 0xf477,
        ///<summary>Solid File Medical Alt</summary>
        ///<see href="https://fontawesome.com/icons/file-medical-alt?style=solid"/>
        [Description("Solid File Medical Alt"), IconID("fas-file-medical-alt")]
        SolidFileMedicalAlt = 0xf478,
        ///<summary>Solid File Pdf</summary>
        ///<see href="https://fontawesome.com/icons/file-pdf?style=solid"/>
        [Description("Solid File Pdf"), IconID("fas-file-pdf")]
        SolidFilePdf = 0xf1c1,
        ///<summary>Solid File Powerpoint</summary>
        ///<see href="https://fontawesome.com/icons/file-powerpoint?style=solid"/>
        [Description("Solid File Powerpoint"), IconID("fas-file-powerpoint")]
        SolidFilePowerpoint = 0xf1c4,
        ///<summary>Solid File Prescription</summary>
        ///<see href="https://fontawesome.com/icons/file-prescription?style=solid"/>
        [Description("Solid File Prescription"), IconID("fas-file-prescription")]
        SolidFilePrescription = 0xf572,
        ///<summary>Solid File Signature</summary>
        ///<see href="https://fontawesome.com/icons/file-signature?style=solid"/>
        [Description("Solid File Signature"), IconID("fas-file-signature")]
        SolidFileSignature = 0xf573,
        ///<summary>Solid File Upload</summary>
        ///<see href="https://fontawesome.com/icons/file-upload?style=solid"/>
        [Description("Solid File Upload"), IconID("fas-file-upload")]
        SolidFileUpload = 0xf574,
        ///<summary>Solid File Video</summary>
        ///<see href="https://fontawesome.com/icons/file-video?style=solid"/>
        [Description("Solid File Video"), IconID("fas-file-video")]
        SolidFileVideo = 0xf1c8,
        ///<summary>Solid File Word</summary>
        ///<see href="https://fontawesome.com/icons/file-word?style=solid"/>
        [Description("Solid File Word"), IconID("fas-file-word")]
        SolidFileWord = 0xf1c2,
        ///<summary>Solid Fill</summary>
        ///<see href="https://fontawesome.com/icons/fill?style=solid"/>
        [Description("Solid Fill"), IconID("fas-fill")]
        SolidFill = 0xf575,
        ///<summary>Solid Fill Drip</summary>
        ///<see href="https://fontawesome.com/icons/fill-drip?style=solid"/>
        [Description("Solid Fill Drip"), IconID("fas-fill-drip")]
        SolidFillDrip = 0xf576,
        ///<summary>Solid Film</summary>
        ///<see href="https://fontawesome.com/icons/film?style=solid"/>
        [Description("Solid Film"), IconID("fas-film")]
        SolidFilm = 0xf008,
        ///<summary>Solid Filter</summary>
        ///<see href="https://fontawesome.com/icons/filter?style=solid"/>
        [Description("Solid Filter"), IconID("fas-filter")]
        SolidFilter = 0xf0b0,
        ///<summary>Solid Fingerprint</summary>
        ///<see href="https://fontawesome.com/icons/fingerprint?style=solid"/>
        [Description("Solid Fingerprint"), IconID("fas-fingerprint")]
        SolidFingerprint = 0xf577,
        ///<summary>Solid Fire</summary>
        ///<see href="https://fontawesome.com/icons/fire?style=solid"/>
        [Description("Solid Fire"), IconID("fas-fire")]
        SolidFire = 0xf06d,
        ///<summary>Solid Fire Alt</summary>
        ///<see href="https://fontawesome.com/icons/fire-alt?style=solid"/>
        [Description("Solid Fire Alt"), IconID("fas-fire-alt")]
        SolidFireAlt = 0xf7e4,
        ///<summary>Solid Fire Extinguisher</summary>
        ///<see href="https://fontawesome.com/icons/fire-extinguisher?style=solid"/>
        [Description("Solid Fire Extinguisher"), IconID("fas-fire-extinguisher")]
        SolidFireExtinguisher = 0xf134,
        ///<summary>Solid First Aid</summary>
        ///<see href="https://fontawesome.com/icons/first-aid?style=solid"/>
        [Description("Solid First Aid"), IconID("fas-first-aid")]
        SolidFirstAid = 0xf479,
        ///<summary>Solid Fish</summary>
        ///<see href="https://fontawesome.com/icons/fish?style=solid"/>
        [Description("Solid Fish"), IconID("fas-fish")]
        SolidFish = 0xf578,
        ///<summary>Solid Fist Raised</summary>
        ///<see href="https://fontawesome.com/icons/fist-raised?style=solid"/>
        [Description("Solid Fist Raised"), IconID("fas-fist-raised")]
        SolidFistRaised = 0xf6de,
        ///<summary>Solid Flag</summary>
        ///<see href="https://fontawesome.com/icons/flag?style=solid"/>
        [Description("Solid Flag"), IconID("fas-flag")]
        SolidFlag = 0xf024,
        ///<summary>Solid Flag Checkered</summary>
        ///<see href="https://fontawesome.com/icons/flag-checkered?style=solid"/>
        [Description("Solid Flag Checkered"), IconID("fas-flag-checkered")]
        SolidFlagCheckered = 0xf11e,
        ///<summary>Solid Flag Usa</summary>
        ///<see href="https://fontawesome.com/icons/flag-usa?style=solid"/>
        [Description("Solid Flag Usa"), IconID("fas-flag-usa")]
        SolidFlagUsa = 0xf74d,
        ///<summary>Solid Flask</summary>
        ///<see href="https://fontawesome.com/icons/flask?style=solid"/>
        [Description("Solid Flask"), IconID("fas-flask")]
        SolidFlask = 0xf0c3,
        ///<summary>Solid Flushed</summary>
        ///<see href="https://fontawesome.com/icons/flushed?style=solid"/>
        [Description("Solid Flushed"), IconID("fas-flushed")]
        SolidFlushed = 0xf579,
        ///<summary>Solid Folder</summary>
        ///<see href="https://fontawesome.com/icons/folder?style=solid"/>
        [Description("Solid Folder"), IconID("fas-folder")]
        SolidFolder = 0xf07b,
        ///<summary>Solid Folder Minus</summary>
        ///<see href="https://fontawesome.com/icons/folder-minus?style=solid"/>
        [Description("Solid Folder Minus"), IconID("fas-folder-minus")]
        SolidFolderMinus = 0xf65d,
        ///<summary>Solid Folder Open</summary>
        ///<see href="https://fontawesome.com/icons/folder-open?style=solid"/>
        [Description("Solid Folder Open"), IconID("fas-folder-open")]
        SolidFolderOpen = 0xf07c,
        ///<summary>Solid Folder Plus</summary>
        ///<see href="https://fontawesome.com/icons/folder-plus?style=solid"/>
        [Description("Solid Folder Plus"), IconID("fas-folder-plus")]
        SolidFolderPlus = 0xf65e,
        ///<summary>Solid Font</summary>
        ///<see href="https://fontawesome.com/icons/font?style=solid"/>
        [Description("Solid Font"), IconID("fas-font")]
        SolidFont = 0xf031,
        ///<summary>Solid Football Ball</summary>
        ///<see href="https://fontawesome.com/icons/football-ball?style=solid"/>
        [Description("Solid Football Ball"), IconID("fas-football-ball")]
        SolidFootballBall = 0xf44e,
        ///<summary>Solid Forward</summary>
        ///<see href="https://fontawesome.com/icons/forward?style=solid"/>
        [Description("Solid Forward"), IconID("fas-forward")]
        SolidForward = 0xf04e,
        ///<summary>Solid Frog</summary>
        ///<see href="https://fontawesome.com/icons/frog?style=solid"/>
        [Description("Solid Frog"), IconID("fas-frog")]
        SolidFrog = 0xf52e,
        ///<summary>Solid Frown</summary>
        ///<see href="https://fontawesome.com/icons/frown?style=solid"/>
        [Description("Solid Frown"), IconID("fas-frown")]
        SolidFrown = 0xf119,
        ///<summary>Solid Frown Open</summary>
        ///<see href="https://fontawesome.com/icons/frown-open?style=solid"/>
        [Description("Solid Frown Open"), IconID("fas-frown-open")]
        SolidFrownOpen = 0xf57a,
        ///<summary>Solid Funnel Dollar</summary>
        ///<see href="https://fontawesome.com/icons/funnel-dollar?style=solid"/>
        [Description("Solid Funnel Dollar"), IconID("fas-funnel-dollar")]
        SolidFunnelDollar = 0xf662,
        ///<summary>Solid Futbol</summary>
        ///<see href="https://fontawesome.com/icons/futbol?style=solid"/>
        [Description("Solid Futbol"), IconID("fas-futbol")]
        SolidFutbol = 0xf1e3,
        ///<summary>Solid Gamepad</summary>
        ///<see href="https://fontawesome.com/icons/gamepad?style=solid"/>
        [Description("Solid Gamepad"), IconID("fas-gamepad")]
        SolidGamepad = 0xf11b,
        ///<summary>Solid Gas Pump</summary>
        ///<see href="https://fontawesome.com/icons/gas-pump?style=solid"/>
        [Description("Solid Gas Pump"), IconID("fas-gas-pump")]
        SolidGasPump = 0xf52f,
        ///<summary>Solid Gavel</summary>
        ///<see href="https://fontawesome.com/icons/gavel?style=solid"/>
        [Description("Solid Gavel"), IconID("fas-gavel")]
        SolidGavel = 0xf0e3,
        ///<summary>Solid Gem</summary>
        ///<see href="https://fontawesome.com/icons/gem?style=solid"/>
        [Description("Solid Gem"), IconID("fas-gem")]
        SolidGem = 0xf3a5,
        ///<summary>Solid Genderless</summary>
        ///<see href="https://fontawesome.com/icons/genderless?style=solid"/>
        [Description("Solid Genderless"), IconID("fas-genderless")]
        SolidGenderless = 0xf22d,
        ///<summary>Solid Ghost</summary>
        ///<see href="https://fontawesome.com/icons/ghost?style=solid"/>
        [Description("Solid Ghost"), IconID("fas-ghost")]
        SolidGhost = 0xf6e2,
        ///<summary>Solid Gift</summary>
        ///<see href="https://fontawesome.com/icons/gift?style=solid"/>
        [Description("Solid Gift"), IconID("fas-gift")]
        SolidGift = 0xf06b,
        ///<summary>Solid Gifts</summary>
        ///<see href="https://fontawesome.com/icons/gifts?style=solid"/>
        [Description("Solid Gifts"), IconID("fas-gifts")]
        SolidGifts = 0xf79c,
        ///<summary>Solid Glass Cheers</summary>
        ///<see href="https://fontawesome.com/icons/glass-cheers?style=solid"/>
        [Description("Solid Glass Cheers"), IconID("fas-glass-cheers")]
        SolidGlassCheers = 0xf79f,
        ///<summary>Solid Glass Martini</summary>
        ///<see href="https://fontawesome.com/icons/glass-martini?style=solid"/>
        [Description("Solid Glass Martini"), IconID("fas-glass-martini")]
        SolidGlassMartini = 0xf000,
        ///<summary>Solid Glass Martini Alt</summary>
        ///<see href="https://fontawesome.com/icons/glass-martini-alt?style=solid"/>
        [Description("Solid Glass Martini Alt"), IconID("fas-glass-martini-alt")]
        SolidGlassMartiniAlt = 0xf57b,
        ///<summary>Solid Glass Whiskey</summary>
        ///<see href="https://fontawesome.com/icons/glass-whiskey?style=solid"/>
        [Description("Solid Glass Whiskey"), IconID("fas-glass-whiskey")]
        SolidGlassWhiskey = 0xf7a0,
        ///<summary>Solid Glasses</summary>
        ///<see href="https://fontawesome.com/icons/glasses?style=solid"/>
        [Description("Solid Glasses"), IconID("fas-glasses")]
        SolidGlasses = 0xf530,
        ///<summary>Solid Globe</summary>
        ///<see href="https://fontawesome.com/icons/globe?style=solid"/>
        [Description("Solid Globe"), IconID("fas-globe")]
        SolidGlobe = 0xf0ac,
        ///<summary>Solid Globe Africa</summary>
        ///<see href="https://fontawesome.com/icons/globe-africa?style=solid"/>
        [Description("Solid Globe Africa"), IconID("fas-globe-africa")]
        SolidGlobeAfrica = 0xf57c,
        ///<summary>Solid Globe Americas</summary>
        ///<see href="https://fontawesome.com/icons/globe-americas?style=solid"/>
        [Description("Solid Globe Americas"), IconID("fas-globe-americas")]
        SolidGlobeAmericas = 0xf57d,
        ///<summary>Solid Globe Asia</summary>
        ///<see href="https://fontawesome.com/icons/globe-asia?style=solid"/>
        [Description("Solid Globe Asia"), IconID("fas-globe-asia")]
        SolidGlobeAsia = 0xf57e,
        ///<summary>Solid Globe Europe</summary>
        ///<see href="https://fontawesome.com/icons/globe-europe?style=solid"/>
        [Description("Solid Globe Europe"), IconID("fas-globe-europe")]
        SolidGlobeEurope = 0xf7a2,
        ///<summary>Solid Golf Ball</summary>
        ///<see href="https://fontawesome.com/icons/golf-ball?style=solid"/>
        [Description("Solid Golf Ball"), IconID("fas-golf-ball")]
        SolidGolfBall = 0xf450,
        ///<summary>Solid Gopuram</summary>
        ///<see href="https://fontawesome.com/icons/gopuram?style=solid"/>
        [Description("Solid Gopuram"), IconID("fas-gopuram")]
        SolidGopuram = 0xf664,
        ///<summary>Solid Graduation Cap</summary>
        ///<see href="https://fontawesome.com/icons/graduation-cap?style=solid"/>
        [Description("Solid Graduation Cap"), IconID("fas-graduation-cap")]
        SolidGraduationCap = 0xf19d,
        ///<summary>Solid Greater Than</summary>
        ///<see href="https://fontawesome.com/icons/greater-than?style=solid"/>
        [Description("Solid Greater Than"), IconID("fas-greater-than")]
        SolidGreaterThan = 0xf531,
        ///<summary>Solid Greater Than Equal</summary>
        ///<see href="https://fontawesome.com/icons/greater-than-equal?style=solid"/>
        [Description("Solid Greater Than Equal"), IconID("fas-greater-than-equal")]
        SolidGreaterThanEqual = 0xf532,
        ///<summary>Solid Grimace</summary>
        ///<see href="https://fontawesome.com/icons/grimace?style=solid"/>
        [Description("Solid Grimace"), IconID("fas-grimace")]
        SolidGrimace = 0xf57f,
        ///<summary>Solid Grin</summary>
        ///<see href="https://fontawesome.com/icons/grin?style=solid"/>
        [Description("Solid Grin"), IconID("fas-grin")]
        SolidGrin = 0xf580,
        ///<summary>Solid Grin Alt</summary>
        ///<see href="https://fontawesome.com/icons/grin-alt?style=solid"/>
        [Description("Solid Grin Alt"), IconID("fas-grin-alt")]
        SolidGrinAlt = 0xf581,
        ///<summary>Solid Grin Beam</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam?style=solid"/>
        [Description("Solid Grin Beam"), IconID("fas-grin-beam")]
        SolidGrinBeam = 0xf582,
        ///<summary>Solid Grin Beam Sweat</summary>
        ///<see href="https://fontawesome.com/icons/grin-beam-sweat?style=solid"/>
        [Description("Solid Grin Beam Sweat"), IconID("fas-grin-beam-sweat")]
        SolidGrinBeamSweat = 0xf583,
        ///<summary>Solid Grin Hearts</summary>
        ///<see href="https://fontawesome.com/icons/grin-hearts?style=solid"/>
        [Description("Solid Grin Hearts"), IconID("fas-grin-hearts")]
        SolidGrinHearts = 0xf584,
        ///<summary>Solid Grin Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint?style=solid"/>
        [Description("Solid Grin Squint"), IconID("fas-grin-squint")]
        SolidGrinSquint = 0xf585,
        ///<summary>Solid Grin Squint Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-squint-tears?style=solid"/>
        [Description("Solid Grin Squint Tears"), IconID("fas-grin-squint-tears")]
        SolidGrinSquintTears = 0xf586,
        ///<summary>Solid Grin Stars</summary>
        ///<see href="https://fontawesome.com/icons/grin-stars?style=solid"/>
        [Description("Solid Grin Stars"), IconID("fas-grin-stars")]
        SolidGrinStars = 0xf587,
        ///<summary>Solid Grin Tears</summary>
        ///<see href="https://fontawesome.com/icons/grin-tears?style=solid"/>
        [Description("Solid Grin Tears"), IconID("fas-grin-tears")]
        SolidGrinTears = 0xf588,
        ///<summary>Solid Grin Tongue</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue?style=solid"/>
        [Description("Solid Grin Tongue"), IconID("fas-grin-tongue")]
        SolidGrinTongue = 0xf589,
        ///<summary>Solid Grin Tongue Squint</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-squint?style=solid"/>
        [Description("Solid Grin Tongue Squint"), IconID("fas-grin-tongue-squint")]
        SolidGrinTongueSquint = 0xf58a,
        ///<summary>Solid Grin Tongue Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-tongue-wink?style=solid"/>
        [Description("Solid Grin Tongue Wink"), IconID("fas-grin-tongue-wink")]
        SolidGrinTongueWink = 0xf58b,
        ///<summary>Solid Grin Wink</summary>
        ///<see href="https://fontawesome.com/icons/grin-wink?style=solid"/>
        [Description("Solid Grin Wink"), IconID("fas-grin-wink")]
        SolidGrinWink = 0xf58c,
        ///<summary>Solid Grip Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/grip-horizontal?style=solid"/>
        [Description("Solid Grip Horizontal"), IconID("fas-grip-horizontal")]
        SolidGripHorizontal = 0xf58d,
        ///<summary>Solid Grip Lines</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines?style=solid"/>
        [Description("Solid Grip Lines"), IconID("fas-grip-lines")]
        SolidGripLines = 0xf7a4,
        ///<summary>Solid Grip Lines Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-lines-vertical?style=solid"/>
        [Description("Solid Grip Lines Vertical"), IconID("fas-grip-lines-vertical")]
        SolidGripLinesVertical = 0xf7a5,
        ///<summary>Solid Grip Vertical</summary>
        ///<see href="https://fontawesome.com/icons/grip-vertical?style=solid"/>
        [Description("Solid Grip Vertical"), IconID("fas-grip-vertical")]
        SolidGripVertical = 0xf58e,
        ///<summary>Solid Guitar</summary>
        ///<see href="https://fontawesome.com/icons/guitar?style=solid"/>
        [Description("Solid Guitar"), IconID("fas-guitar")]
        SolidGuitar = 0xf7a6,
        ///<summary>Solid H Square</summary>
        ///<see href="https://fontawesome.com/icons/h-square?style=solid"/>
        [Description("Solid H Square"), IconID("fas-h-square")]
        SolidHSquare = 0xf0fd,
        ///<summary>Solid Hamburger</summary>
        ///<see href="https://fontawesome.com/icons/hamburger?style=solid"/>
        [Description("Solid Hamburger"), IconID("fas-hamburger")]
        SolidHamburger = 0xf805,
        ///<summary>Solid Hammer</summary>
        ///<see href="https://fontawesome.com/icons/hammer?style=solid"/>
        [Description("Solid Hammer"), IconID("fas-hammer")]
        SolidHammer = 0xf6e3,
        ///<summary>Solid Hamsa</summary>
        ///<see href="https://fontawesome.com/icons/hamsa?style=solid"/>
        [Description("Solid Hamsa"), IconID("fas-hamsa")]
        SolidHamsa = 0xf665,
        ///<summary>Solid Hand Holding</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding?style=solid"/>
        [Description("Solid Hand Holding"), IconID("fas-hand-holding")]
        SolidHandHolding = 0xf4bd,
        ///<summary>Solid Hand Holding Heart</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-heart?style=solid"/>
        [Description("Solid Hand Holding Heart"), IconID("fas-hand-holding-heart")]
        SolidHandHoldingHeart = 0xf4be,
        ///<summary>Solid Hand Holding Medical</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-medical?style=solid"/>
        [Description("Solid Hand Holding Medical"), IconID("fas-hand-holding-medical")]
        SolidHandHoldingMedical = 0xe05c,
        ///<summary>Solid Hand Holding Usd</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-usd?style=solid"/>
        [Description("Solid Hand Holding Usd"), IconID("fas-hand-holding-usd")]
        SolidHandHoldingUsd = 0xf4c0,
        ///<summary>Solid Hand Holding Water</summary>
        ///<see href="https://fontawesome.com/icons/hand-holding-water?style=solid"/>
        [Description("Solid Hand Holding Water"), IconID("fas-hand-holding-water")]
        SolidHandHoldingWater = 0xf4c1,
        ///<summary>Solid Hand Lizard</summary>
        ///<see href="https://fontawesome.com/icons/hand-lizard?style=solid"/>
        [Description("Solid Hand Lizard"), IconID("fas-hand-lizard")]
        SolidHandLizard = 0xf258,
        ///<summary>Solid Hand Middle Finger</summary>
        ///<see href="https://fontawesome.com/icons/hand-middle-finger?style=solid"/>
        [Description("Solid Hand Middle Finger"), IconID("fas-hand-middle-finger")]
        SolidHandMiddleFinger = 0xf806,
        ///<summary>Solid Hand Paper</summary>
        ///<see href="https://fontawesome.com/icons/hand-paper?style=solid"/>
        [Description("Solid Hand Paper"), IconID("fas-hand-paper")]
        SolidHandPaper = 0xf256,
        ///<summary>Solid Hand Peace</summary>
        ///<see href="https://fontawesome.com/icons/hand-peace?style=solid"/>
        [Description("Solid Hand Peace"), IconID("fas-hand-peace")]
        SolidHandPeace = 0xf25b,
        ///<summary>Solid Hand Point Down</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-down?style=solid"/>
        [Description("Solid Hand Point Down"), IconID("fas-hand-point-down")]
        SolidHandPointDown = 0xf0a7,
        ///<summary>Solid Hand Point Left</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-left?style=solid"/>
        [Description("Solid Hand Point Left"), IconID("fas-hand-point-left")]
        SolidHandPointLeft = 0xf0a5,
        ///<summary>Solid Hand Point Right</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-right?style=solid"/>
        [Description("Solid Hand Point Right"), IconID("fas-hand-point-right")]
        SolidHandPointRight = 0xf0a4,
        ///<summary>Solid Hand Point Up</summary>
        ///<see href="https://fontawesome.com/icons/hand-point-up?style=solid"/>
        [Description("Solid Hand Point Up"), IconID("fas-hand-point-up")]
        SolidHandPointUp = 0xf0a6,
        ///<summary>Solid Hand Pointer</summary>
        ///<see href="https://fontawesome.com/icons/hand-pointer?style=solid"/>
        [Description("Solid Hand Pointer"), IconID("fas-hand-pointer")]
        SolidHandPointer = 0xf25a,
        ///<summary>Solid Hand Rock</summary>
        ///<see href="https://fontawesome.com/icons/hand-rock?style=solid"/>
        [Description("Solid Hand Rock"), IconID("fas-hand-rock")]
        SolidHandRock = 0xf255,
        ///<summary>Solid Hand Scissors</summary>
        ///<see href="https://fontawesome.com/icons/hand-scissors?style=solid"/>
        [Description("Solid Hand Scissors"), IconID("fas-hand-scissors")]
        SolidHandScissors = 0xf257,
        ///<summary>Solid Hand Sparkles</summary>
        ///<see href="https://fontawesome.com/icons/hand-sparkles?style=solid"/>
        [Description("Solid Hand Sparkles"), IconID("fas-hand-sparkles")]
        SolidHandSparkles = 0xe05d,
        ///<summary>Solid Hand Spock</summary>
        ///<see href="https://fontawesome.com/icons/hand-spock?style=solid"/>
        [Description("Solid Hand Spock"), IconID("fas-hand-spock")]
        SolidHandSpock = 0xf259,
        ///<summary>Solid Hands</summary>
        ///<see href="https://fontawesome.com/icons/hands?style=solid"/>
        [Description("Solid Hands"), IconID("fas-hands")]
        SolidHands = 0xf4c2,
        ///<summary>Solid Hands Helping</summary>
        ///<see href="https://fontawesome.com/icons/hands-helping?style=solid"/>
        [Description("Solid Hands Helping"), IconID("fas-hands-helping")]
        SolidHandsHelping = 0xf4c4,
        ///<summary>Solid Hands Wash</summary>
        ///<see href="https://fontawesome.com/icons/hands-wash?style=solid"/>
        [Description("Solid Hands Wash"), IconID("fas-hands-wash")]
        SolidHandsWash = 0xe05e,
        ///<summary>Solid Handshake</summary>
        ///<see href="https://fontawesome.com/icons/handshake?style=solid"/>
        [Description("Solid Handshake"), IconID("fas-handshake")]
        SolidHandshake = 0xf2b5,
        ///<summary>Solid Handshake Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-alt-slash?style=solid"/>
        [Description("Solid Handshake Alt Slash"), IconID("fas-handshake-alt-slash")]
        SolidHandshakeAltSlash = 0xe05f,
        ///<summary>Solid Handshake Slash</summary>
        ///<see href="https://fontawesome.com/icons/handshake-slash?style=solid"/>
        [Description("Solid Handshake Slash"), IconID("fas-handshake-slash")]
        SolidHandshakeSlash = 0xe060,
        ///<summary>Solid Hanukiah</summary>
        ///<see href="https://fontawesome.com/icons/hanukiah?style=solid"/>
        [Description("Solid Hanukiah"), IconID("fas-hanukiah")]
        SolidHanukiah = 0xf6e6,
        ///<summary>Solid Hard Hat</summary>
        ///<see href="https://fontawesome.com/icons/hard-hat?style=solid"/>
        [Description("Solid Hard Hat"), IconID("fas-hard-hat")]
        SolidHardHat = 0xf807,
        ///<summary>Solid Hashtag</summary>
        ///<see href="https://fontawesome.com/icons/hashtag?style=solid"/>
        [Description("Solid Hashtag"), IconID("fas-hashtag")]
        SolidHashtag = 0xf292,
        ///<summary>Solid Hat Cowboy</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy?style=solid"/>
        [Description("Solid Hat Cowboy"), IconID("fas-hat-cowboy")]
        SolidHatCowboy = 0xf8c0,
        ///<summary>Solid Hat Cowboy Side</summary>
        ///<see href="https://fontawesome.com/icons/hat-cowboy-side?style=solid"/>
        [Description("Solid Hat Cowboy Side"), IconID("fas-hat-cowboy-side")]
        SolidHatCowboySide = 0xf8c1,
        ///<summary>Solid Hat Wizard</summary>
        ///<see href="https://fontawesome.com/icons/hat-wizard?style=solid"/>
        [Description("Solid Hat Wizard"), IconID("fas-hat-wizard")]
        SolidHatWizard = 0xf6e8,
        ///<summary>Solid Hdd</summary>
        ///<see href="https://fontawesome.com/icons/hdd?style=solid"/>
        [Description("Solid Hdd"), IconID("fas-hdd")]
        SolidHdd = 0xf0a0,
        ///<summary>Solid Head Side Cough</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough?style=solid"/>
        [Description("Solid Head Side Cough"), IconID("fas-head-side-cough")]
        SolidHeadSideCough = 0xe061,
        ///<summary>Solid Head Side Cough Slash</summary>
        ///<see href="https://fontawesome.com/icons/head-side-cough-slash?style=solid"/>
        [Description("Solid Head Side Cough Slash"), IconID("fas-head-side-cough-slash")]
        SolidHeadSideCoughSlash = 0xe062,
        ///<summary>Solid Head Side Mask</summary>
        ///<see href="https://fontawesome.com/icons/head-side-mask?style=solid"/>
        [Description("Solid Head Side Mask"), IconID("fas-head-side-mask")]
        SolidHeadSideMask = 0xe063,
        ///<summary>Solid Head Side Virus</summary>
        ///<see href="https://fontawesome.com/icons/head-side-virus?style=solid"/>
        [Description("Solid Head Side Virus"), IconID("fas-head-side-virus")]
        SolidHeadSideVirus = 0xe064,
        ///<summary>Solid Heading</summary>
        ///<see href="https://fontawesome.com/icons/heading?style=solid"/>
        [Description("Solid Heading"), IconID("fas-heading")]
        SolidHeading = 0xf1dc,
        ///<summary>Solid Headphones</summary>
        ///<see href="https://fontawesome.com/icons/headphones?style=solid"/>
        [Description("Solid Headphones"), IconID("fas-headphones")]
        SolidHeadphones = 0xf025,
        ///<summary>Solid Headphones Alt</summary>
        ///<see href="https://fontawesome.com/icons/headphones-alt?style=solid"/>
        [Description("Solid Headphones Alt"), IconID("fas-headphones-alt")]
        SolidHeadphonesAlt = 0xf58f,
        ///<summary>Solid Headset</summary>
        ///<see href="https://fontawesome.com/icons/headset?style=solid"/>
        [Description("Solid Headset"), IconID("fas-headset")]
        SolidHeadset = 0xf590,
        ///<summary>Solid Heart</summary>
        ///<see href="https://fontawesome.com/icons/heart?style=solid"/>
        [Description("Solid Heart"), IconID("fas-heart")]
        SolidHeart = 0xf004,
        ///<summary>Solid Heart Broken</summary>
        ///<see href="https://fontawesome.com/icons/heart-broken?style=solid"/>
        [Description("Solid Heart Broken"), IconID("fas-heart-broken")]
        SolidHeartBroken = 0xf7a9,
        ///<summary>Solid Heartbeat</summary>
        ///<see href="https://fontawesome.com/icons/heartbeat?style=solid"/>
        [Description("Solid Heartbeat"), IconID("fas-heartbeat")]
        SolidHeartbeat = 0xf21e,
        ///<summary>Solid Helicopter</summary>
        ///<see href="https://fontawesome.com/icons/helicopter?style=solid"/>
        [Description("Solid Helicopter"), IconID("fas-helicopter")]
        SolidHelicopter = 0xf533,
        ///<summary>Solid Highlighter</summary>
        ///<see href="https://fontawesome.com/icons/highlighter?style=solid"/>
        [Description("Solid Highlighter"), IconID("fas-highlighter")]
        SolidHighlighter = 0xf591,
        ///<summary>Solid Hiking</summary>
        ///<see href="https://fontawesome.com/icons/hiking?style=solid"/>
        [Description("Solid Hiking"), IconID("fas-hiking")]
        SolidHiking = 0xf6ec,
        ///<summary>Solid Hippo</summary>
        ///<see href="https://fontawesome.com/icons/hippo?style=solid"/>
        [Description("Solid Hippo"), IconID("fas-hippo")]
        SolidHippo = 0xf6ed,
        ///<summary>Solid History</summary>
        ///<see href="https://fontawesome.com/icons/history?style=solid"/>
        [Description("Solid History"), IconID("fas-history")]
        SolidHistory = 0xf1da,
        ///<summary>Solid Hockey Puck</summary>
        ///<see href="https://fontawesome.com/icons/hockey-puck?style=solid"/>
        [Description("Solid Hockey Puck"), IconID("fas-hockey-puck")]
        SolidHockeyPuck = 0xf453,
        ///<summary>Solid Holly Berry</summary>
        ///<see href="https://fontawesome.com/icons/holly-berry?style=solid"/>
        [Description("Solid Holly Berry"), IconID("fas-holly-berry")]
        SolidHollyBerry = 0xf7aa,
        ///<summary>Solid Home</summary>
        ///<see href="https://fontawesome.com/icons/home?style=solid"/>
        [Description("Solid Home"), IconID("fas-home")]
        SolidHome = 0xf015,
        ///<summary>Solid Horse</summary>
        ///<see href="https://fontawesome.com/icons/horse?style=solid"/>
        [Description("Solid Horse"), IconID("fas-horse")]
        SolidHorse = 0xf6f0,
        ///<summary>Solid Horse Head</summary>
        ///<see href="https://fontawesome.com/icons/horse-head?style=solid"/>
        [Description("Solid Horse Head"), IconID("fas-horse-head")]
        SolidHorseHead = 0xf7ab,
        ///<summary>Solid Hospital</summary>
        ///<see href="https://fontawesome.com/icons/hospital?style=solid"/>
        [Description("Solid Hospital"), IconID("fas-hospital")]
        SolidHospital = 0xf0f8,
        ///<summary>Solid Hospital Alt</summary>
        ///<see href="https://fontawesome.com/icons/hospital-alt?style=solid"/>
        [Description("Solid Hospital Alt"), IconID("fas-hospital-alt")]
        SolidHospitalAlt = 0xf47d,
        ///<summary>Solid Hospital Symbol</summary>
        ///<see href="https://fontawesome.com/icons/hospital-symbol?style=solid"/>
        [Description("Solid Hospital Symbol"), IconID("fas-hospital-symbol")]
        SolidHospitalSymbol = 0xf47e,
        ///<summary>Solid Hospital User</summary>
        ///<see href="https://fontawesome.com/icons/hospital-user?style=solid"/>
        [Description("Solid Hospital User"), IconID("fas-hospital-user")]
        SolidHospitalUser = 0xf80d,
        ///<summary>Solid Hot Tub</summary>
        ///<see href="https://fontawesome.com/icons/hot-tub?style=solid"/>
        [Description("Solid Hot Tub"), IconID("fas-hot-tub")]
        SolidHotTub = 0xf593,
        ///<summary>Solid Hotdog</summary>
        ///<see href="https://fontawesome.com/icons/hotdog?style=solid"/>
        [Description("Solid Hotdog"), IconID("fas-hotdog")]
        SolidHotdog = 0xf80f,
        ///<summary>Solid Hotel</summary>
        ///<see href="https://fontawesome.com/icons/hotel?style=solid"/>
        [Description("Solid Hotel"), IconID("fas-hotel")]
        SolidHotel = 0xf594,
        ///<summary>Solid Hourglass</summary>
        ///<see href="https://fontawesome.com/icons/hourglass?style=solid"/>
        [Description("Solid Hourglass"), IconID("fas-hourglass")]
        SolidHourglass = 0xf254,
        ///<summary>Solid Hourglass End</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-end?style=solid"/>
        [Description("Solid Hourglass End"), IconID("fas-hourglass-end")]
        SolidHourglassEnd = 0xf253,
        ///<summary>Solid Hourglass Half</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-half?style=solid"/>
        [Description("Solid Hourglass Half"), IconID("fas-hourglass-half")]
        SolidHourglassHalf = 0xf252,
        ///<summary>Solid Hourglass Start</summary>
        ///<see href="https://fontawesome.com/icons/hourglass-start?style=solid"/>
        [Description("Solid Hourglass Start"), IconID("fas-hourglass-start")]
        SolidHourglassStart = 0xf251,
        ///<summary>Solid House Damage</summary>
        ///<see href="https://fontawesome.com/icons/house-damage?style=solid"/>
        [Description("Solid House Damage"), IconID("fas-house-damage")]
        SolidHouseDamage = 0xf6f1,
        ///<summary>Solid House User</summary>
        ///<see href="https://fontawesome.com/icons/house-user?style=solid"/>
        [Description("Solid House User"), IconID("fas-house-user")]
        SolidHouseUser = 0xe065,
        ///<summary>Solid Hryvnia</summary>
        ///<see href="https://fontawesome.com/icons/hryvnia?style=solid"/>
        [Description("Solid Hryvnia"), IconID("fas-hryvnia")]
        SolidHryvnia = 0xf6f2,
        ///<summary>Solid I Cursor</summary>
        ///<see href="https://fontawesome.com/icons/i-cursor?style=solid"/>
        [Description("Solid I Cursor"), IconID("fas-i-cursor")]
        SolidICursor = 0xf246,
        ///<summary>Solid Ice Cream</summary>
        ///<see href="https://fontawesome.com/icons/ice-cream?style=solid"/>
        [Description("Solid Ice Cream"), IconID("fas-ice-cream")]
        SolidIceCream = 0xf810,
        ///<summary>Solid Icicles</summary>
        ///<see href="https://fontawesome.com/icons/icicles?style=solid"/>
        [Description("Solid Icicles"), IconID("fas-icicles")]
        SolidIcicles = 0xf7ad,
        ///<summary>Solid Icons</summary>
        ///<see href="https://fontawesome.com/icons/icons?style=solid"/>
        [Description("Solid Icons"), IconID("fas-icons")]
        SolidIcons = 0xf86d,
        ///<summary>Solid Id Badge</summary>
        ///<see href="https://fontawesome.com/icons/id-badge?style=solid"/>
        [Description("Solid Id Badge"), IconID("fas-id-badge")]
        SolidIdBadge = 0xf2c1,
        ///<summary>Solid Id Card</summary>
        ///<see href="https://fontawesome.com/icons/id-card?style=solid"/>
        [Description("Solid Id Card"), IconID("fas-id-card")]
        SolidIdCard = 0xf2c2,
        ///<summary>Solid Id Card Alt</summary>
        ///<see href="https://fontawesome.com/icons/id-card-alt?style=solid"/>
        [Description("Solid Id Card Alt"), IconID("fas-id-card-alt")]
        SolidIdCardAlt = 0xf47f,
        ///<summary>Solid Igloo</summary>
        ///<see href="https://fontawesome.com/icons/igloo?style=solid"/>
        [Description("Solid Igloo"), IconID("fas-igloo")]
        SolidIgloo = 0xf7ae,
        ///<summary>Solid Image</summary>
        ///<see href="https://fontawesome.com/icons/image?style=solid"/>
        [Description("Solid Image"), IconID("fas-image")]
        SolidImage = 0xf03e,
        ///<summary>Solid Images</summary>
        ///<see href="https://fontawesome.com/icons/images?style=solid"/>
        [Description("Solid Images"), IconID("fas-images")]
        SolidImages = 0xf302,
        ///<summary>Solid Inbox</summary>
        ///<see href="https://fontawesome.com/icons/inbox?style=solid"/>
        [Description("Solid Inbox"), IconID("fas-inbox")]
        SolidInbox = 0xf01c,
        ///<summary>Solid Indent</summary>
        ///<see href="https://fontawesome.com/icons/indent?style=solid"/>
        [Description("Solid Indent"), IconID("fas-indent")]
        SolidIndent = 0xf03c,
        ///<summary>Solid Industry</summary>
        ///<see href="https://fontawesome.com/icons/industry?style=solid"/>
        [Description("Solid Industry"), IconID("fas-industry")]
        SolidIndustry = 0xf275,
        ///<summary>Solid Infinity</summary>
        ///<see href="https://fontawesome.com/icons/infinity?style=solid"/>
        [Description("Solid Infinity"), IconID("fas-infinity")]
        SolidInfinity = 0xf534,
        ///<summary>Solid Info</summary>
        ///<see href="https://fontawesome.com/icons/info?style=solid"/>
        [Description("Solid Info"), IconID("fas-info")]
        SolidInfo = 0xf129,
        ///<summary>Solid Info Circle</summary>
        ///<see href="https://fontawesome.com/icons/info-circle?style=solid"/>
        [Description("Solid Info Circle"), IconID("fas-info-circle")]
        SolidInfoCircle = 0xf05a,
        ///<summary>Solid Italic</summary>
        ///<see href="https://fontawesome.com/icons/italic?style=solid"/>
        [Description("Solid Italic"), IconID("fas-italic")]
        SolidItalic = 0xf033,
        ///<summary>Solid Jedi</summary>
        ///<see href="https://fontawesome.com/icons/jedi?style=solid"/>
        [Description("Solid Jedi"), IconID("fas-jedi")]
        SolidJedi = 0xf669,
        ///<summary>Solid Joint</summary>
        ///<see href="https://fontawesome.com/icons/joint?style=solid"/>
        [Description("Solid Joint"), IconID("fas-joint")]
        SolidJoint = 0xf595,
        ///<summary>Solid Journal Whills</summary>
        ///<see href="https://fontawesome.com/icons/journal-whills?style=solid"/>
        [Description("Solid Journal Whills"), IconID("fas-journal-whills")]
        SolidJournalWhills = 0xf66a,
        ///<summary>Solid Kaaba</summary>
        ///<see href="https://fontawesome.com/icons/kaaba?style=solid"/>
        [Description("Solid Kaaba"), IconID("fas-kaaba")]
        SolidKaaba = 0xf66b,
        ///<summary>Solid Key</summary>
        ///<see href="https://fontawesome.com/icons/key?style=solid"/>
        [Description("Solid Key"), IconID("fas-key")]
        SolidKey = 0xf084,
        ///<summary>Solid Keyboard</summary>
        ///<see href="https://fontawesome.com/icons/keyboard?style=solid"/>
        [Description("Solid Keyboard"), IconID("fas-keyboard")]
        SolidKeyboard = 0xf11c,
        ///<summary>Solid Khanda</summary>
        ///<see href="https://fontawesome.com/icons/khanda?style=solid"/>
        [Description("Solid Khanda"), IconID("fas-khanda")]
        SolidKhanda = 0xf66d,
        ///<summary>Solid Kiss</summary>
        ///<see href="https://fontawesome.com/icons/kiss?style=solid"/>
        [Description("Solid Kiss"), IconID("fas-kiss")]
        SolidKiss = 0xf596,
        ///<summary>Solid Kiss Beam</summary>
        ///<see href="https://fontawesome.com/icons/kiss-beam?style=solid"/>
        [Description("Solid Kiss Beam"), IconID("fas-kiss-beam")]
        SolidKissBeam = 0xf597,
        ///<summary>Solid Kiss Wink Heart</summary>
        ///<see href="https://fontawesome.com/icons/kiss-wink-heart?style=solid"/>
        [Description("Solid Kiss Wink Heart"), IconID("fas-kiss-wink-heart")]
        SolidKissWinkHeart = 0xf598,
        ///<summary>Solid Kiwi Bird</summary>
        ///<see href="https://fontawesome.com/icons/kiwi-bird?style=solid"/>
        [Description("Solid Kiwi Bird"), IconID("fas-kiwi-bird")]
        SolidKiwiBird = 0xf535,
        ///<summary>Solid Landmark</summary>
        ///<see href="https://fontawesome.com/icons/landmark?style=solid"/>
        [Description("Solid Landmark"), IconID("fas-landmark")]
        SolidLandmark = 0xf66f,
        ///<summary>Solid Language</summary>
        ///<see href="https://fontawesome.com/icons/language?style=solid"/>
        [Description("Solid Language"), IconID("fas-language")]
        SolidLanguage = 0xf1ab,
        ///<summary>Solid Laptop</summary>
        ///<see href="https://fontawesome.com/icons/laptop?style=solid"/>
        [Description("Solid Laptop"), IconID("fas-laptop")]
        SolidLaptop = 0xf109,
        ///<summary>Solid Laptop Code</summary>
        ///<see href="https://fontawesome.com/icons/laptop-code?style=solid"/>
        [Description("Solid Laptop Code"), IconID("fas-laptop-code")]
        SolidLaptopCode = 0xf5fc,
        ///<summary>Solid Laptop House</summary>
        ///<see href="https://fontawesome.com/icons/laptop-house?style=solid"/>
        [Description("Solid Laptop House"), IconID("fas-laptop-house")]
        SolidLaptopHouse = 0xe066,
        ///<summary>Solid Laptop Medical</summary>
        ///<see href="https://fontawesome.com/icons/laptop-medical?style=solid"/>
        [Description("Solid Laptop Medical"), IconID("fas-laptop-medical")]
        SolidLaptopMedical = 0xf812,
        ///<summary>Solid Laugh</summary>
        ///<see href="https://fontawesome.com/icons/laugh?style=solid"/>
        [Description("Solid Laugh"), IconID("fas-laugh")]
        SolidLaugh = 0xf599,
        ///<summary>Solid Laugh Beam</summary>
        ///<see href="https://fontawesome.com/icons/laugh-beam?style=solid"/>
        [Description("Solid Laugh Beam"), IconID("fas-laugh-beam")]
        SolidLaughBeam = 0xf59a,
        ///<summary>Solid Laugh Squint</summary>
        ///<see href="https://fontawesome.com/icons/laugh-squint?style=solid"/>
        [Description("Solid Laugh Squint"), IconID("fas-laugh-squint")]
        SolidLaughSquint = 0xf59b,
        ///<summary>Solid Laugh Wink</summary>
        ///<see href="https://fontawesome.com/icons/laugh-wink?style=solid"/>
        [Description("Solid Laugh Wink"), IconID("fas-laugh-wink")]
        SolidLaughWink = 0xf59c,
        ///<summary>Solid Layer Group</summary>
        ///<see href="https://fontawesome.com/icons/layer-group?style=solid"/>
        [Description("Solid Layer Group"), IconID("fas-layer-group")]
        SolidLayerGroup = 0xf5fd,
        ///<summary>Solid Leaf</summary>
        ///<see href="https://fontawesome.com/icons/leaf?style=solid"/>
        [Description("Solid Leaf"), IconID("fas-leaf")]
        SolidLeaf = 0xf06c,
        ///<summary>Solid Lemon</summary>
        ///<see href="https://fontawesome.com/icons/lemon?style=solid"/>
        [Description("Solid Lemon"), IconID("fas-lemon")]
        SolidLemon = 0xf094,
        ///<summary>Solid Less Than</summary>
        ///<see href="https://fontawesome.com/icons/less-than?style=solid"/>
        [Description("Solid Less Than"), IconID("fas-less-than")]
        SolidLessThan = 0xf536,
        ///<summary>Solid Less Than Equal</summary>
        ///<see href="https://fontawesome.com/icons/less-than-equal?style=solid"/>
        [Description("Solid Less Than Equal"), IconID("fas-less-than-equal")]
        SolidLessThanEqual = 0xf537,
        ///<summary>Solid Level Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/level-down-alt?style=solid"/>
        [Description("Solid Level Down Alt"), IconID("fas-level-down-alt")]
        SolidLevelDownAlt = 0xf3be,
        ///<summary>Solid Level Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/level-up-alt?style=solid"/>
        [Description("Solid Level Up Alt"), IconID("fas-level-up-alt")]
        SolidLevelUpAlt = 0xf3bf,
        ///<summary>Solid Life Ring</summary>
        ///<see href="https://fontawesome.com/icons/life-ring?style=solid"/>
        [Description("Solid Life Ring"), IconID("fas-life-ring")]
        SolidLifeRing = 0xf1cd,
        ///<summary>Solid Lightbulb</summary>
        ///<see href="https://fontawesome.com/icons/lightbulb?style=solid"/>
        [Description("Solid Lightbulb"), IconID("fas-lightbulb")]
        SolidLightbulb = 0xf0eb,
        ///<summary>Solid Link</summary>
        ///<see href="https://fontawesome.com/icons/link?style=solid"/>
        [Description("Solid Link"), IconID("fas-link")]
        SolidLink = 0xf0c1,
        ///<summary>Solid Lira Sign</summary>
        ///<see href="https://fontawesome.com/icons/lira-sign?style=solid"/>
        [Description("Solid Lira Sign"), IconID("fas-lira-sign")]
        SolidLiraSign = 0xf195,
        ///<summary>Solid List</summary>
        ///<see href="https://fontawesome.com/icons/list?style=solid"/>
        [Description("Solid List"), IconID("fas-list")]
        SolidList = 0xf03a,
        ///<summary>Solid List Alt</summary>
        ///<see href="https://fontawesome.com/icons/list-alt?style=solid"/>
        [Description("Solid List Alt"), IconID("fas-list-alt")]
        SolidListAlt = 0xf022,
        ///<summary>Solid List Ol</summary>
        ///<see href="https://fontawesome.com/icons/list-ol?style=solid"/>
        [Description("Solid List Ol"), IconID("fas-list-ol")]
        SolidListOl = 0xf0cb,
        ///<summary>Solid List Ul</summary>
        ///<see href="https://fontawesome.com/icons/list-ul?style=solid"/>
        [Description("Solid List Ul"), IconID("fas-list-ul")]
        SolidListUl = 0xf0ca,
        ///<summary>Solid Location Arrow</summary>
        ///<see href="https://fontawesome.com/icons/location-arrow?style=solid"/>
        [Description("Solid Location Arrow"), IconID("fas-location-arrow")]
        SolidLocationArrow = 0xf124,
        ///<summary>Solid Lock</summary>
        ///<see href="https://fontawesome.com/icons/lock?style=solid"/>
        [Description("Solid Lock"), IconID("fas-lock")]
        SolidLock = 0xf023,
        ///<summary>Solid Lock Open</summary>
        ///<see href="https://fontawesome.com/icons/lock-open?style=solid"/>
        [Description("Solid Lock Open"), IconID("fas-lock-open")]
        SolidLockOpen = 0xf3c1,
        ///<summary>Solid Long Arrow Alt Down</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-down?style=solid"/>
        [Description("Solid Long Arrow Alt Down"), IconID("fas-long-arrow-alt-down")]
        SolidLongArrowAltDown = 0xf309,
        ///<summary>Solid Long Arrow Alt Left</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-left?style=solid"/>
        [Description("Solid Long Arrow Alt Left"), IconID("fas-long-arrow-alt-left")]
        SolidLongArrowAltLeft = 0xf30a,
        ///<summary>Solid Long Arrow Alt Right</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-right?style=solid"/>
        [Description("Solid Long Arrow Alt Right"), IconID("fas-long-arrow-alt-right")]
        SolidLongArrowAltRight = 0xf30b,
        ///<summary>Solid Long Arrow Alt Up</summary>
        ///<see href="https://fontawesome.com/icons/long-arrow-alt-up?style=solid"/>
        [Description("Solid Long Arrow Alt Up"), IconID("fas-long-arrow-alt-up")]
        SolidLongArrowAltUp = 0xf30c,
        ///<summary>Solid Low Vision</summary>
        ///<see href="https://fontawesome.com/icons/low-vision?style=solid"/>
        [Description("Solid Low Vision"), IconID("fas-low-vision")]
        SolidLowVision = 0xf2a8,
        ///<summary>Solid Luggage Cart</summary>
        ///<see href="https://fontawesome.com/icons/luggage-cart?style=solid"/>
        [Description("Solid Luggage Cart"), IconID("fas-luggage-cart")]
        SolidLuggageCart = 0xf59d,
        ///<summary>Solid Lungs</summary>
        ///<see href="https://fontawesome.com/icons/lungs?style=solid"/>
        [Description("Solid Lungs"), IconID("fas-lungs")]
        SolidLungs = 0xf604,
        ///<summary>Solid Lungs Virus</summary>
        ///<see href="https://fontawesome.com/icons/lungs-virus?style=solid"/>
        [Description("Solid Lungs Virus"), IconID("fas-lungs-virus")]
        SolidLungsVirus = 0xe067,
        ///<summary>Solid Magic</summary>
        ///<see href="https://fontawesome.com/icons/magic?style=solid"/>
        [Description("Solid Magic"), IconID("fas-magic")]
        SolidMagic = 0xf0d0,
        ///<summary>Solid Magnet</summary>
        ///<see href="https://fontawesome.com/icons/magnet?style=solid"/>
        [Description("Solid Magnet"), IconID("fas-magnet")]
        SolidMagnet = 0xf076,
        ///<summary>Solid Mail Bulk</summary>
        ///<see href="https://fontawesome.com/icons/mail-bulk?style=solid"/>
        [Description("Solid Mail Bulk"), IconID("fas-mail-bulk")]
        SolidMailBulk = 0xf674,
        ///<summary>Solid Male</summary>
        ///<see href="https://fontawesome.com/icons/male?style=solid"/>
        [Description("Solid Male"), IconID("fas-male")]
        SolidMale = 0xf183,
        ///<summary>Solid Map</summary>
        ///<see href="https://fontawesome.com/icons/map?style=solid"/>
        [Description("Solid Map"), IconID("fas-map")]
        SolidMap = 0xf279,
        ///<summary>Solid Map Marked</summary>
        ///<see href="https://fontawesome.com/icons/map-marked?style=solid"/>
        [Description("Solid Map Marked"), IconID("fas-map-marked")]
        SolidMapMarked = 0xf59f,
        ///<summary>Solid Map Marked Alt</summary>
        ///<see href="https://fontawesome.com/icons/map-marked-alt?style=solid"/>
        [Description("Solid Map Marked Alt"), IconID("fas-map-marked-alt")]
        SolidMapMarkedAlt = 0xf5a0,
        ///<summary>Solid Map Marker</summary>
        ///<see href="https://fontawesome.com/icons/map-marker?style=solid"/>
        [Description("Solid Map Marker"), IconID("fas-map-marker")]
        SolidMapMarker = 0xf041,
        ///<summary>Solid Map Marker Alt</summary>
        ///<see href="https://fontawesome.com/icons/map-marker-alt?style=solid"/>
        [Description("Solid Map Marker Alt"), IconID("fas-map-marker-alt")]
        SolidMapMarkerAlt = 0xf3c5,
        ///<summary>Solid Map Pin</summary>
        ///<see href="https://fontawesome.com/icons/map-pin?style=solid"/>
        [Description("Solid Map Pin"), IconID("fas-map-pin")]
        SolidMapPin = 0xf276,
        ///<summary>Solid Map Signs</summary>
        ///<see href="https://fontawesome.com/icons/map-signs?style=solid"/>
        [Description("Solid Map Signs"), IconID("fas-map-signs")]
        SolidMapSigns = 0xf277,
        ///<summary>Solid Marker</summary>
        ///<see href="https://fontawesome.com/icons/marker?style=solid"/>
        [Description("Solid Marker"), IconID("fas-marker")]
        SolidMarker = 0xf5a1,
        ///<summary>Solid Mars</summary>
        ///<see href="https://fontawesome.com/icons/mars?style=solid"/>
        [Description("Solid Mars"), IconID("fas-mars")]
        SolidMars = 0xf222,
        ///<summary>Solid Mars Double</summary>
        ///<see href="https://fontawesome.com/icons/mars-double?style=solid"/>
        [Description("Solid Mars Double"), IconID("fas-mars-double")]
        SolidMarsDouble = 0xf227,
        ///<summary>Solid Mars Stroke</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke?style=solid"/>
        [Description("Solid Mars Stroke"), IconID("fas-mars-stroke")]
        SolidMarsStroke = 0xf229,
        ///<summary>Solid Mars Stroke H</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-h?style=solid"/>
        [Description("Solid Mars Stroke H"), IconID("fas-mars-stroke-h")]
        SolidMarsStrokeH = 0xf22b,
        ///<summary>Solid Mars Stroke V</summary>
        ///<see href="https://fontawesome.com/icons/mars-stroke-v?style=solid"/>
        [Description("Solid Mars Stroke V"), IconID("fas-mars-stroke-v")]
        SolidMarsStrokeV = 0xf22a,
        ///<summary>Solid Mask</summary>
        ///<see href="https://fontawesome.com/icons/mask?style=solid"/>
        [Description("Solid Mask"), IconID("fas-mask")]
        SolidMask = 0xf6fa,
        ///<summary>Solid Medal</summary>
        ///<see href="https://fontawesome.com/icons/medal?style=solid"/>
        [Description("Solid Medal"), IconID("fas-medal")]
        SolidMedal = 0xf5a2,
        ///<summary>Solid Medkit</summary>
        ///<see href="https://fontawesome.com/icons/medkit?style=solid"/>
        [Description("Solid Medkit"), IconID("fas-medkit")]
        SolidMedkit = 0xf0fa,
        ///<summary>Solid Meh</summary>
        ///<see href="https://fontawesome.com/icons/meh?style=solid"/>
        [Description("Solid Meh"), IconID("fas-meh")]
        SolidMeh = 0xf11a,
        ///<summary>Solid Meh Blank</summary>
        ///<see href="https://fontawesome.com/icons/meh-blank?style=solid"/>
        [Description("Solid Meh Blank"), IconID("fas-meh-blank")]
        SolidMehBlank = 0xf5a4,
        ///<summary>Solid Meh Rolling Eyes</summary>
        ///<see href="https://fontawesome.com/icons/meh-rolling-eyes?style=solid"/>
        [Description("Solid Meh Rolling Eyes"), IconID("fas-meh-rolling-eyes")]
        SolidMehRollingEyes = 0xf5a5,
        ///<summary>Solid Memory</summary>
        ///<see href="https://fontawesome.com/icons/memory?style=solid"/>
        [Description("Solid Memory"), IconID("fas-memory")]
        SolidMemory = 0xf538,
        ///<summary>Solid Menorah</summary>
        ///<see href="https://fontawesome.com/icons/menorah?style=solid"/>
        [Description("Solid Menorah"), IconID("fas-menorah")]
        SolidMenorah = 0xf676,
        ///<summary>Solid Mercury</summary>
        ///<see href="https://fontawesome.com/icons/mercury?style=solid"/>
        [Description("Solid Mercury"), IconID("fas-mercury")]
        SolidMercury = 0xf223,
        ///<summary>Solid Meteor</summary>
        ///<see href="https://fontawesome.com/icons/meteor?style=solid"/>
        [Description("Solid Meteor"), IconID("fas-meteor")]
        SolidMeteor = 0xf753,
        ///<summary>Solid Microchip</summary>
        ///<see href="https://fontawesome.com/icons/microchip?style=solid"/>
        [Description("Solid Microchip"), IconID("fas-microchip")]
        SolidMicrochip = 0xf2db,
        ///<summary>Solid Microphone</summary>
        ///<see href="https://fontawesome.com/icons/microphone?style=solid"/>
        [Description("Solid Microphone"), IconID("fas-microphone")]
        SolidMicrophone = 0xf130,
        ///<summary>Solid Microphone Alt</summary>
        ///<see href="https://fontawesome.com/icons/microphone-alt?style=solid"/>
        [Description("Solid Microphone Alt"), IconID("fas-microphone-alt")]
        SolidMicrophoneAlt = 0xf3c9,
        ///<summary>Solid Microphone Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-alt-slash?style=solid"/>
        [Description("Solid Microphone Alt Slash"), IconID("fas-microphone-alt-slash")]
        SolidMicrophoneAltSlash = 0xf539,
        ///<summary>Solid Microphone Slash</summary>
        ///<see href="https://fontawesome.com/icons/microphone-slash?style=solid"/>
        [Description("Solid Microphone Slash"), IconID("fas-microphone-slash")]
        SolidMicrophoneSlash = 0xf131,
        ///<summary>Solid Microscope</summary>
        ///<see href="https://fontawesome.com/icons/microscope?style=solid"/>
        [Description("Solid Microscope"), IconID("fas-microscope")]
        SolidMicroscope = 0xf610,
        ///<summary>Solid Minus</summary>
        ///<see href="https://fontawesome.com/icons/minus?style=solid"/>
        [Description("Solid Minus"), IconID("fas-minus")]
        SolidMinus = 0xf068,
        ///<summary>Solid Minus Circle</summary>
        ///<see href="https://fontawesome.com/icons/minus-circle?style=solid"/>
        [Description("Solid Minus Circle"), IconID("fas-minus-circle")]
        SolidMinusCircle = 0xf056,
        ///<summary>Solid Minus Square</summary>
        ///<see href="https://fontawesome.com/icons/minus-square?style=solid"/>
        [Description("Solid Minus Square"), IconID("fas-minus-square")]
        SolidMinusSquare = 0xf146,
        ///<summary>Solid Mitten</summary>
        ///<see href="https://fontawesome.com/icons/mitten?style=solid"/>
        [Description("Solid Mitten"), IconID("fas-mitten")]
        SolidMitten = 0xf7b5,
        ///<summary>Solid Mobile</summary>
        ///<see href="https://fontawesome.com/icons/mobile?style=solid"/>
        [Description("Solid Mobile"), IconID("fas-mobile")]
        SolidMobile = 0xf10b,
        ///<summary>Solid Mobile Alt</summary>
        ///<see href="https://fontawesome.com/icons/mobile-alt?style=solid"/>
        [Description("Solid Mobile Alt"), IconID("fas-mobile-alt")]
        SolidMobileAlt = 0xf3cd,
        ///<summary>Solid Money Bill</summary>
        ///<see href="https://fontawesome.com/icons/money-bill?style=solid"/>
        [Description("Solid Money Bill"), IconID("fas-money-bill")]
        SolidMoneyBill = 0xf0d6,
        ///<summary>Solid Money Bill Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-alt?style=solid"/>
        [Description("Solid Money Bill Alt"), IconID("fas-money-bill-alt")]
        SolidMoneyBillAlt = 0xf3d1,
        ///<summary>Solid Money Bill Wave</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wave?style=solid"/>
        [Description("Solid Money Bill Wave"), IconID("fas-money-bill-wave")]
        SolidMoneyBillWave = 0xf53a,
        ///<summary>Solid Money Bill Wave Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-bill-wave-alt?style=solid"/>
        [Description("Solid Money Bill Wave Alt"), IconID("fas-money-bill-wave-alt")]
        SolidMoneyBillWaveAlt = 0xf53b,
        ///<summary>Solid Money Check</summary>
        ///<see href="https://fontawesome.com/icons/money-check?style=solid"/>
        [Description("Solid Money Check"), IconID("fas-money-check")]
        SolidMoneyCheck = 0xf53c,
        ///<summary>Solid Money Check Alt</summary>
        ///<see href="https://fontawesome.com/icons/money-check-alt?style=solid"/>
        [Description("Solid Money Check Alt"), IconID("fas-money-check-alt")]
        SolidMoneyCheckAlt = 0xf53d,
        ///<summary>Solid Monument</summary>
        ///<see href="https://fontawesome.com/icons/monument?style=solid"/>
        [Description("Solid Monument"), IconID("fas-monument")]
        SolidMonument = 0xf5a6,
        ///<summary>Solid Moon</summary>
        ///<see href="https://fontawesome.com/icons/moon?style=solid"/>
        [Description("Solid Moon"), IconID("fas-moon")]
        SolidMoon = 0xf186,
        ///<summary>Solid Mortar Pestle</summary>
        ///<see href="https://fontawesome.com/icons/mortar-pestle?style=solid"/>
        [Description("Solid Mortar Pestle"), IconID("fas-mortar-pestle")]
        SolidMortarPestle = 0xf5a7,
        ///<summary>Solid Mosque</summary>
        ///<see href="https://fontawesome.com/icons/mosque?style=solid"/>
        [Description("Solid Mosque"), IconID("fas-mosque")]
        SolidMosque = 0xf678,
        ///<summary>Solid Motorcycle</summary>
        ///<see href="https://fontawesome.com/icons/motorcycle?style=solid"/>
        [Description("Solid Motorcycle"), IconID("fas-motorcycle")]
        SolidMotorcycle = 0xf21c,
        ///<summary>Solid Mountain</summary>
        ///<see href="https://fontawesome.com/icons/mountain?style=solid"/>
        [Description("Solid Mountain"), IconID("fas-mountain")]
        SolidMountain = 0xf6fc,
        ///<summary>Solid Mouse</summary>
        ///<see href="https://fontawesome.com/icons/mouse?style=solid"/>
        [Description("Solid Mouse"), IconID("fas-mouse")]
        SolidMouse = 0xf8cc,
        ///<summary>Solid Mouse Pointer</summary>
        ///<see href="https://fontawesome.com/icons/mouse-pointer?style=solid"/>
        [Description("Solid Mouse Pointer"), IconID("fas-mouse-pointer")]
        SolidMousePointer = 0xf245,
        ///<summary>Solid Mug Hot</summary>
        ///<see href="https://fontawesome.com/icons/mug-hot?style=solid"/>
        [Description("Solid Mug Hot"), IconID("fas-mug-hot")]
        SolidMugHot = 0xf7b6,
        ///<summary>Solid Music</summary>
        ///<see href="https://fontawesome.com/icons/music?style=solid"/>
        [Description("Solid Music"), IconID("fas-music")]
        SolidMusic = 0xf001,
        ///<summary>Solid Network Wired</summary>
        ///<see href="https://fontawesome.com/icons/network-wired?style=solid"/>
        [Description("Solid Network Wired"), IconID("fas-network-wired")]
        SolidNetworkWired = 0xf6ff,
        ///<summary>Solid Neuter</summary>
        ///<see href="https://fontawesome.com/icons/neuter?style=solid"/>
        [Description("Solid Neuter"), IconID("fas-neuter")]
        SolidNeuter = 0xf22c,
        ///<summary>Solid Newspaper</summary>
        ///<see href="https://fontawesome.com/icons/newspaper?style=solid"/>
        [Description("Solid Newspaper"), IconID("fas-newspaper")]
        SolidNewspaper = 0xf1ea,
        ///<summary>Solid Not Equal</summary>
        ///<see href="https://fontawesome.com/icons/not-equal?style=solid"/>
        [Description("Solid Not Equal"), IconID("fas-not-equal")]
        SolidNotEqual = 0xf53e,
        ///<summary>Solid Notes Medical</summary>
        ///<see href="https://fontawesome.com/icons/notes-medical?style=solid"/>
        [Description("Solid Notes Medical"), IconID("fas-notes-medical")]
        SolidNotesMedical = 0xf481,
        ///<summary>Solid Object Group</summary>
        ///<see href="https://fontawesome.com/icons/object-group?style=solid"/>
        [Description("Solid Object Group"), IconID("fas-object-group")]
        SolidObjectGroup = 0xf247,
        ///<summary>Solid Object Ungroup</summary>
        ///<see href="https://fontawesome.com/icons/object-ungroup?style=solid"/>
        [Description("Solid Object Ungroup"), IconID("fas-object-ungroup")]
        SolidObjectUngroup = 0xf248,
        ///<summary>Solid Oil Can</summary>
        ///<see href="https://fontawesome.com/icons/oil-can?style=solid"/>
        [Description("Solid Oil Can"), IconID("fas-oil-can")]
        SolidOilCan = 0xf613,
        ///<summary>Solid Om</summary>
        ///<see href="https://fontawesome.com/icons/om?style=solid"/>
        [Description("Solid Om"), IconID("fas-om")]
        SolidOm = 0xf679,
        ///<summary>Solid Otter</summary>
        ///<see href="https://fontawesome.com/icons/otter?style=solid"/>
        [Description("Solid Otter"), IconID("fas-otter")]
        SolidOtter = 0xf700,
        ///<summary>Solid Outdent</summary>
        ///<see href="https://fontawesome.com/icons/outdent?style=solid"/>
        [Description("Solid Outdent"), IconID("fas-outdent")]
        SolidOutdent = 0xf03b,
        ///<summary>Solid Pager</summary>
        ///<see href="https://fontawesome.com/icons/pager?style=solid"/>
        [Description("Solid Pager"), IconID("fas-pager")]
        SolidPager = 0xf815,
        ///<summary>Solid Paint Brush</summary>
        ///<see href="https://fontawesome.com/icons/paint-brush?style=solid"/>
        [Description("Solid Paint Brush"), IconID("fas-paint-brush")]
        SolidPaintBrush = 0xf1fc,
        ///<summary>Solid Paint Roller</summary>
        ///<see href="https://fontawesome.com/icons/paint-roller?style=solid"/>
        [Description("Solid Paint Roller"), IconID("fas-paint-roller")]
        SolidPaintRoller = 0xf5aa,
        ///<summary>Solid Palette</summary>
        ///<see href="https://fontawesome.com/icons/palette?style=solid"/>
        [Description("Solid Palette"), IconID("fas-palette")]
        SolidPalette = 0xf53f,
        ///<summary>Solid Pallet</summary>
        ///<see href="https://fontawesome.com/icons/pallet?style=solid"/>
        [Description("Solid Pallet"), IconID("fas-pallet")]
        SolidPallet = 0xf482,
        ///<summary>Solid Paper Plane</summary>
        ///<see href="https://fontawesome.com/icons/paper-plane?style=solid"/>
        [Description("Solid Paper Plane"), IconID("fas-paper-plane")]
        SolidPaperPlane = 0xf1d8,
        ///<summary>Solid Paperclip</summary>
        ///<see href="https://fontawesome.com/icons/paperclip?style=solid"/>
        [Description("Solid Paperclip"), IconID("fas-paperclip")]
        SolidPaperclip = 0xf0c6,
        ///<summary>Solid Parachute Box</summary>
        ///<see href="https://fontawesome.com/icons/parachute-box?style=solid"/>
        [Description("Solid Parachute Box"), IconID("fas-parachute-box")]
        SolidParachuteBox = 0xf4cd,
        ///<summary>Solid Paragraph</summary>
        ///<see href="https://fontawesome.com/icons/paragraph?style=solid"/>
        [Description("Solid Paragraph"), IconID("fas-paragraph")]
        SolidParagraph = 0xf1dd,
        ///<summary>Solid Parking</summary>
        ///<see href="https://fontawesome.com/icons/parking?style=solid"/>
        [Description("Solid Parking"), IconID("fas-parking")]
        SolidParking = 0xf540,
        ///<summary>Solid Passport</summary>
        ///<see href="https://fontawesome.com/icons/passport?style=solid"/>
        [Description("Solid Passport"), IconID("fas-passport")]
        SolidPassport = 0xf5ab,
        ///<summary>Solid Pastafarianism</summary>
        ///<see href="https://fontawesome.com/icons/pastafarianism?style=solid"/>
        [Description("Solid Pastafarianism"), IconID("fas-pastafarianism")]
        SolidPastafarianism = 0xf67b,
        ///<summary>Solid Paste</summary>
        ///<see href="https://fontawesome.com/icons/paste?style=solid"/>
        [Description("Solid Paste"), IconID("fas-paste")]
        SolidPaste = 0xf0ea,
        ///<summary>Solid Pause</summary>
        ///<see href="https://fontawesome.com/icons/pause?style=solid"/>
        [Description("Solid Pause"), IconID("fas-pause")]
        SolidPause = 0xf04c,
        ///<summary>Solid Pause Circle</summary>
        ///<see href="https://fontawesome.com/icons/pause-circle?style=solid"/>
        [Description("Solid Pause Circle"), IconID("fas-pause-circle")]
        SolidPauseCircle = 0xf28b,
        ///<summary>Solid Paw</summary>
        ///<see href="https://fontawesome.com/icons/paw?style=solid"/>
        [Description("Solid Paw"), IconID("fas-paw")]
        SolidPaw = 0xf1b0,
        ///<summary>Solid Peace</summary>
        ///<see href="https://fontawesome.com/icons/peace?style=solid"/>
        [Description("Solid Peace"), IconID("fas-peace")]
        SolidPeace = 0xf67c,
        ///<summary>Solid Pen</summary>
        ///<see href="https://fontawesome.com/icons/pen?style=solid"/>
        [Description("Solid Pen"), IconID("fas-pen")]
        SolidPen = 0xf304,
        ///<summary>Solid Pen Alt</summary>
        ///<see href="https://fontawesome.com/icons/pen-alt?style=solid"/>
        [Description("Solid Pen Alt"), IconID("fas-pen-alt")]
        SolidPenAlt = 0xf305,
        ///<summary>Solid Pen Fancy</summary>
        ///<see href="https://fontawesome.com/icons/pen-fancy?style=solid"/>
        [Description("Solid Pen Fancy"), IconID("fas-pen-fancy")]
        SolidPenFancy = 0xf5ac,
        ///<summary>Solid Pen Nib</summary>
        ///<see href="https://fontawesome.com/icons/pen-nib?style=solid"/>
        [Description("Solid Pen Nib"), IconID("fas-pen-nib")]
        SolidPenNib = 0xf5ad,
        ///<summary>Solid Pen Square</summary>
        ///<see href="https://fontawesome.com/icons/pen-square?style=solid"/>
        [Description("Solid Pen Square"), IconID("fas-pen-square")]
        SolidPenSquare = 0xf14b,
        ///<summary>Solid Pencil Alt</summary>
        ///<see href="https://fontawesome.com/icons/pencil-alt?style=solid"/>
        [Description("Solid Pencil Alt"), IconID("fas-pencil-alt")]
        SolidPencilAlt = 0xf303,
        ///<summary>Solid Pencil Ruler</summary>
        ///<see href="https://fontawesome.com/icons/pencil-ruler?style=solid"/>
        [Description("Solid Pencil Ruler"), IconID("fas-pencil-ruler")]
        SolidPencilRuler = 0xf5ae,
        ///<summary>Solid People Arrows</summary>
        ///<see href="https://fontawesome.com/icons/people-arrows?style=solid"/>
        [Description("Solid People Arrows"), IconID("fas-people-arrows")]
        SolidPeopleArrows = 0xe068,
        ///<summary>Solid People Carry</summary>
        ///<see href="https://fontawesome.com/icons/people-carry?style=solid"/>
        [Description("Solid People Carry"), IconID("fas-people-carry")]
        SolidPeopleCarry = 0xf4ce,
        ///<summary>Solid Pepper Hot</summary>
        ///<see href="https://fontawesome.com/icons/pepper-hot?style=solid"/>
        [Description("Solid Pepper Hot"), IconID("fas-pepper-hot")]
        SolidPepperHot = 0xf816,
        ///<summary>Solid Percent</summary>
        ///<see href="https://fontawesome.com/icons/percent?style=solid"/>
        [Description("Solid Percent"), IconID("fas-percent")]
        SolidPercent = 0xf295,
        ///<summary>Solid Percentage</summary>
        ///<see href="https://fontawesome.com/icons/percentage?style=solid"/>
        [Description("Solid Percentage"), IconID("fas-percentage")]
        SolidPercentage = 0xf541,
        ///<summary>Solid Person Booth</summary>
        ///<see href="https://fontawesome.com/icons/person-booth?style=solid"/>
        [Description("Solid Person Booth"), IconID("fas-person-booth")]
        SolidPersonBooth = 0xf756,
        ///<summary>Solid Phone</summary>
        ///<see href="https://fontawesome.com/icons/phone?style=solid"/>
        [Description("Solid Phone"), IconID("fas-phone")]
        SolidPhone = 0xf095,
        ///<summary>Solid Phone Alt</summary>
        ///<see href="https://fontawesome.com/icons/phone-alt?style=solid"/>
        [Description("Solid Phone Alt"), IconID("fas-phone-alt")]
        SolidPhoneAlt = 0xf879,
        ///<summary>Solid Phone Slash</summary>
        ///<see href="https://fontawesome.com/icons/phone-slash?style=solid"/>
        [Description("Solid Phone Slash"), IconID("fas-phone-slash")]
        SolidPhoneSlash = 0xf3dd,
        ///<summary>Solid Phone Square</summary>
        ///<see href="https://fontawesome.com/icons/phone-square?style=solid"/>
        [Description("Solid Phone Square"), IconID("fas-phone-square")]
        SolidPhoneSquare = 0xf098,
        ///<summary>Solid Phone Square Alt</summary>
        ///<see href="https://fontawesome.com/icons/phone-square-alt?style=solid"/>
        [Description("Solid Phone Square Alt"), IconID("fas-phone-square-alt")]
        SolidPhoneSquareAlt = 0xf87b,
        ///<summary>Solid Phone Volume</summary>
        ///<see href="https://fontawesome.com/icons/phone-volume?style=solid"/>
        [Description("Solid Phone Volume"), IconID("fas-phone-volume")]
        SolidPhoneVolume = 0xf2a0,
        ///<summary>Solid Photo Video</summary>
        ///<see href="https://fontawesome.com/icons/photo-video?style=solid"/>
        [Description("Solid Photo Video"), IconID("fas-photo-video")]
        SolidPhotoVideo = 0xf87c,
        ///<summary>Solid Piggy Bank</summary>
        ///<see href="https://fontawesome.com/icons/piggy-bank?style=solid"/>
        [Description("Solid Piggy Bank"), IconID("fas-piggy-bank")]
        SolidPiggyBank = 0xf4d3,
        ///<summary>Solid Pills</summary>
        ///<see href="https://fontawesome.com/icons/pills?style=solid"/>
        [Description("Solid Pills"), IconID("fas-pills")]
        SolidPills = 0xf484,
        ///<summary>Solid Pizza Slice</summary>
        ///<see href="https://fontawesome.com/icons/pizza-slice?style=solid"/>
        [Description("Solid Pizza Slice"), IconID("fas-pizza-slice")]
        SolidPizzaSlice = 0xf818,
        ///<summary>Solid Place Of Worship</summary>
        ///<see href="https://fontawesome.com/icons/place-of-worship?style=solid"/>
        [Description("Solid Place Of Worship"), IconID("fas-place-of-worship")]
        SolidPlaceOfWorship = 0xf67f,
        ///<summary>Solid Plane</summary>
        ///<see href="https://fontawesome.com/icons/plane?style=solid"/>
        [Description("Solid Plane"), IconID("fas-plane")]
        SolidPlane = 0xf072,
        ///<summary>Solid Plane Arrival</summary>
        ///<see href="https://fontawesome.com/icons/plane-arrival?style=solid"/>
        [Description("Solid Plane Arrival"), IconID("fas-plane-arrival")]
        SolidPlaneArrival = 0xf5af,
        ///<summary>Solid Plane Departure</summary>
        ///<see href="https://fontawesome.com/icons/plane-departure?style=solid"/>
        [Description("Solid Plane Departure"), IconID("fas-plane-departure")]
        SolidPlaneDeparture = 0xf5b0,
        ///<summary>Solid Plane Slash</summary>
        ///<see href="https://fontawesome.com/icons/plane-slash?style=solid"/>
        [Description("Solid Plane Slash"), IconID("fas-plane-slash")]
        SolidPlaneSlash = 0xe069,
        ///<summary>Solid Play</summary>
        ///<see href="https://fontawesome.com/icons/play?style=solid"/>
        [Description("Solid Play"), IconID("fas-play")]
        SolidPlay = 0xf04b,
        ///<summary>Solid Play Circle</summary>
        ///<see href="https://fontawesome.com/icons/play-circle?style=solid"/>
        [Description("Solid Play Circle"), IconID("fas-play-circle")]
        SolidPlayCircle = 0xf144,
        ///<summary>Solid Plug</summary>
        ///<see href="https://fontawesome.com/icons/plug?style=solid"/>
        [Description("Solid Plug"), IconID("fas-plug")]
        SolidPlug = 0xf1e6,
        ///<summary>Solid Plus</summary>
        ///<see href="https://fontawesome.com/icons/plus?style=solid"/>
        [Description("Solid Plus"), IconID("fas-plus")]
        SolidPlus = 0xf067,
        ///<summary>Solid Plus Circle</summary>
        ///<see href="https://fontawesome.com/icons/plus-circle?style=solid"/>
        [Description("Solid Plus Circle"), IconID("fas-plus-circle")]
        SolidPlusCircle = 0xf055,
        ///<summary>Solid Plus Square</summary>
        ///<see href="https://fontawesome.com/icons/plus-square?style=solid"/>
        [Description("Solid Plus Square"), IconID("fas-plus-square")]
        SolidPlusSquare = 0xf0fe,
        ///<summary>Solid Podcast</summary>
        ///<see href="https://fontawesome.com/icons/podcast?style=solid"/>
        [Description("Solid Podcast"), IconID("fas-podcast")]
        SolidPodcast = 0xf2ce,
        ///<summary>Solid Poll</summary>
        ///<see href="https://fontawesome.com/icons/poll?style=solid"/>
        [Description("Solid Poll"), IconID("fas-poll")]
        SolidPoll = 0xf681,
        ///<summary>Solid Poll H</summary>
        ///<see href="https://fontawesome.com/icons/poll-h?style=solid"/>
        [Description("Solid Poll H"), IconID("fas-poll-h")]
        SolidPollH = 0xf682,
        ///<summary>Solid Poo</summary>
        ///<see href="https://fontawesome.com/icons/poo?style=solid"/>
        [Description("Solid Poo"), IconID("fas-poo")]
        SolidPoo = 0xf2fe,
        ///<summary>Solid Poo Storm</summary>
        ///<see href="https://fontawesome.com/icons/poo-storm?style=solid"/>
        [Description("Solid Poo Storm"), IconID("fas-poo-storm")]
        SolidPooStorm = 0xf75a,
        ///<summary>Solid Poop</summary>
        ///<see href="https://fontawesome.com/icons/poop?style=solid"/>
        [Description("Solid Poop"), IconID("fas-poop")]
        SolidPoop = 0xf619,
        ///<summary>Solid Portrait</summary>
        ///<see href="https://fontawesome.com/icons/portrait?style=solid"/>
        [Description("Solid Portrait"), IconID("fas-portrait")]
        SolidPortrait = 0xf3e0,
        ///<summary>Solid Pound Sign</summary>
        ///<see href="https://fontawesome.com/icons/pound-sign?style=solid"/>
        [Description("Solid Pound Sign"), IconID("fas-pound-sign")]
        SolidPoundSign = 0xf154,
        ///<summary>Solid Power Off</summary>
        ///<see href="https://fontawesome.com/icons/power-off?style=solid"/>
        [Description("Solid Power Off"), IconID("fas-power-off")]
        SolidPowerOff = 0xf011,
        ///<summary>Solid Pray</summary>
        ///<see href="https://fontawesome.com/icons/pray?style=solid"/>
        [Description("Solid Pray"), IconID("fas-pray")]
        SolidPray = 0xf683,
        ///<summary>Solid Praying Hands</summary>
        ///<see href="https://fontawesome.com/icons/praying-hands?style=solid"/>
        [Description("Solid Praying Hands"), IconID("fas-praying-hands")]
        SolidPrayingHands = 0xf684,
        ///<summary>Solid Prescription</summary>
        ///<see href="https://fontawesome.com/icons/prescription?style=solid"/>
        [Description("Solid Prescription"), IconID("fas-prescription")]
        SolidPrescription = 0xf5b1,
        ///<summary>Solid Prescription Bottle</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle?style=solid"/>
        [Description("Solid Prescription Bottle"), IconID("fas-prescription-bottle")]
        SolidPrescriptionBottle = 0xf485,
        ///<summary>Solid Prescription Bottle Alt</summary>
        ///<see href="https://fontawesome.com/icons/prescription-bottle-alt?style=solid"/>
        [Description("Solid Prescription Bottle Alt"), IconID("fas-prescription-bottle-alt")]
        SolidPrescriptionBottleAlt = 0xf486,
        ///<summary>Solid Print</summary>
        ///<see href="https://fontawesome.com/icons/print?style=solid"/>
        [Description("Solid Print"), IconID("fas-print")]
        SolidPrint = 0xf02f,
        ///<summary>Solid Procedures</summary>
        ///<see href="https://fontawesome.com/icons/procedures?style=solid"/>
        [Description("Solid Procedures"), IconID("fas-procedures")]
        SolidProcedures = 0xf487,
        ///<summary>Solid Project Diagram</summary>
        ///<see href="https://fontawesome.com/icons/project-diagram?style=solid"/>
        [Description("Solid Project Diagram"), IconID("fas-project-diagram")]
        SolidProjectDiagram = 0xf542,
        ///<summary>Solid Pump Medical</summary>
        ///<see href="https://fontawesome.com/icons/pump-medical?style=solid"/>
        [Description("Solid Pump Medical"), IconID("fas-pump-medical")]
        SolidPumpMedical = 0xe06a,
        ///<summary>Solid Pump Soap</summary>
        ///<see href="https://fontawesome.com/icons/pump-soap?style=solid"/>
        [Description("Solid Pump Soap"), IconID("fas-pump-soap")]
        SolidPumpSoap = 0xe06b,
        ///<summary>Solid Puzzle Piece</summary>
        ///<see href="https://fontawesome.com/icons/puzzle-piece?style=solid"/>
        [Description("Solid Puzzle Piece"), IconID("fas-puzzle-piece")]
        SolidPuzzlePiece = 0xf12e,
        ///<summary>Solid Qrcode</summary>
        ///<see href="https://fontawesome.com/icons/qrcode?style=solid"/>
        [Description("Solid Qrcode"), IconID("fas-qrcode")]
        SolidQrcode = 0xf029,
        ///<summary>Solid Question</summary>
        ///<see href="https://fontawesome.com/icons/question?style=solid"/>
        [Description("Solid Question"), IconID("fas-question")]
        SolidQuestion = 0xf128,
        ///<summary>Solid Question Circle</summary>
        ///<see href="https://fontawesome.com/icons/question-circle?style=solid"/>
        [Description("Solid Question Circle"), IconID("fas-question-circle")]
        SolidQuestionCircle = 0xf059,
        ///<summary>Solid Quidditch</summary>
        ///<see href="https://fontawesome.com/icons/quidditch?style=solid"/>
        [Description("Solid Quidditch"), IconID("fas-quidditch")]
        SolidQuidditch = 0xf458,
        ///<summary>Solid Quote Left</summary>
        ///<see href="https://fontawesome.com/icons/quote-left?style=solid"/>
        [Description("Solid Quote Left"), IconID("fas-quote-left")]
        SolidQuoteLeft = 0xf10d,
        ///<summary>Solid Quote Right</summary>
        ///<see href="https://fontawesome.com/icons/quote-right?style=solid"/>
        [Description("Solid Quote Right"), IconID("fas-quote-right")]
        SolidQuoteRight = 0xf10e,
        ///<summary>Solid Quran</summary>
        ///<see href="https://fontawesome.com/icons/quran?style=solid"/>
        [Description("Solid Quran"), IconID("fas-quran")]
        SolidQuran = 0xf687,
        ///<summary>Solid Radiation</summary>
        ///<see href="https://fontawesome.com/icons/radiation?style=solid"/>
        [Description("Solid Radiation"), IconID("fas-radiation")]
        SolidRadiation = 0xf7b9,
        ///<summary>Solid Radiation Alt</summary>
        ///<see href="https://fontawesome.com/icons/radiation-alt?style=solid"/>
        [Description("Solid Radiation Alt"), IconID("fas-radiation-alt")]
        SolidRadiationAlt = 0xf7ba,
        ///<summary>Solid Rainbow</summary>
        ///<see href="https://fontawesome.com/icons/rainbow?style=solid"/>
        [Description("Solid Rainbow"), IconID("fas-rainbow")]
        SolidRainbow = 0xf75b,
        ///<summary>Solid Random</summary>
        ///<see href="https://fontawesome.com/icons/random?style=solid"/>
        [Description("Solid Random"), IconID("fas-random")]
        SolidRandom = 0xf074,
        ///<summary>Solid Receipt</summary>
        ///<see href="https://fontawesome.com/icons/receipt?style=solid"/>
        [Description("Solid Receipt"), IconID("fas-receipt")]
        SolidReceipt = 0xf543,
        ///<summary>Solid Record Vinyl</summary>
        ///<see href="https://fontawesome.com/icons/record-vinyl?style=solid"/>
        [Description("Solid Record Vinyl"), IconID("fas-record-vinyl")]
        SolidRecordVinyl = 0xf8d9,
        ///<summary>Solid Recycle</summary>
        ///<see href="https://fontawesome.com/icons/recycle?style=solid"/>
        [Description("Solid Recycle"), IconID("fas-recycle")]
        SolidRecycle = 0xf1b8,
        ///<summary>Solid Redo</summary>
        ///<see href="https://fontawesome.com/icons/redo?style=solid"/>
        [Description("Solid Redo"), IconID("fas-redo")]
        SolidRedo = 0xf01e,
        ///<summary>Solid Redo Alt</summary>
        ///<see href="https://fontawesome.com/icons/redo-alt?style=solid"/>
        [Description("Solid Redo Alt"), IconID("fas-redo-alt")]
        SolidRedoAlt = 0xf2f9,
        ///<summary>Solid Registered</summary>
        ///<see href="https://fontawesome.com/icons/registered?style=solid"/>
        [Description("Solid Registered"), IconID("fas-registered")]
        SolidRegistered = 0xf25d,
        ///<summary>Solid Remove Format</summary>
        ///<see href="https://fontawesome.com/icons/remove-format?style=solid"/>
        [Description("Solid Remove Format"), IconID("fas-remove-format")]
        SolidRemoveFormat = 0xf87d,
        ///<summary>Solid Reply</summary>
        ///<see href="https://fontawesome.com/icons/reply?style=solid"/>
        [Description("Solid Reply"), IconID("fas-reply")]
        SolidReply = 0xf3e5,
        ///<summary>Solid Reply All</summary>
        ///<see href="https://fontawesome.com/icons/reply-all?style=solid"/>
        [Description("Solid Reply All"), IconID("fas-reply-all")]
        SolidReplyAll = 0xf122,
        ///<summary>Solid Republican</summary>
        ///<see href="https://fontawesome.com/icons/republican?style=solid"/>
        [Description("Solid Republican"), IconID("fas-republican")]
        SolidRepublican = 0xf75e,
        ///<summary>Solid Restroom</summary>
        ///<see href="https://fontawesome.com/icons/restroom?style=solid"/>
        [Description("Solid Restroom"), IconID("fas-restroom")]
        SolidRestroom = 0xf7bd,
        ///<summary>Solid Retweet</summary>
        ///<see href="https://fontawesome.com/icons/retweet?style=solid"/>
        [Description("Solid Retweet"), IconID("fas-retweet")]
        SolidRetweet = 0xf079,
        ///<summary>Solid Ribbon</summary>
        ///<see href="https://fontawesome.com/icons/ribbon?style=solid"/>
        [Description("Solid Ribbon"), IconID("fas-ribbon")]
        SolidRibbon = 0xf4d6,
        ///<summary>Solid Ring</summary>
        ///<see href="https://fontawesome.com/icons/ring?style=solid"/>
        [Description("Solid Ring"), IconID("fas-ring")]
        SolidRing = 0xf70b,
        ///<summary>Solid Road</summary>
        ///<see href="https://fontawesome.com/icons/road?style=solid"/>
        [Description("Solid Road"), IconID("fas-road")]
        SolidRoad = 0xf018,
        ///<summary>Solid Robot</summary>
        ///<see href="https://fontawesome.com/icons/robot?style=solid"/>
        [Description("Solid Robot"), IconID("fas-robot")]
        SolidRobot = 0xf544,
        ///<summary>Solid Rocket</summary>
        ///<see href="https://fontawesome.com/icons/rocket?style=solid"/>
        [Description("Solid Rocket"), IconID("fas-rocket")]
        SolidRocket = 0xf135,
        ///<summary>Solid Route</summary>
        ///<see href="https://fontawesome.com/icons/route?style=solid"/>
        [Description("Solid Route"), IconID("fas-route")]
        SolidRoute = 0xf4d7,
        ///<summary>Solid Rss</summary>
        ///<see href="https://fontawesome.com/icons/rss?style=solid"/>
        [Description("Solid Rss"), IconID("fas-rss")]
        SolidRss = 0xf09e,
        ///<summary>Solid Rss Square</summary>
        ///<see href="https://fontawesome.com/icons/rss-square?style=solid"/>
        [Description("Solid Rss Square"), IconID("fas-rss-square")]
        SolidRssSquare = 0xf143,
        ///<summary>Solid Ruble Sign</summary>
        ///<see href="https://fontawesome.com/icons/ruble-sign?style=solid"/>
        [Description("Solid Ruble Sign"), IconID("fas-ruble-sign")]
        SolidRubleSign = 0xf158,
        ///<summary>Solid Ruler</summary>
        ///<see href="https://fontawesome.com/icons/ruler?style=solid"/>
        [Description("Solid Ruler"), IconID("fas-ruler")]
        SolidRuler = 0xf545,
        ///<summary>Solid Ruler Combined</summary>
        ///<see href="https://fontawesome.com/icons/ruler-combined?style=solid"/>
        [Description("Solid Ruler Combined"), IconID("fas-ruler-combined")]
        SolidRulerCombined = 0xf546,
        ///<summary>Solid Ruler Horizontal</summary>
        ///<see href="https://fontawesome.com/icons/ruler-horizontal?style=solid"/>
        [Description("Solid Ruler Horizontal"), IconID("fas-ruler-horizontal")]
        SolidRulerHorizontal = 0xf547,
        ///<summary>Solid Ruler Vertical</summary>
        ///<see href="https://fontawesome.com/icons/ruler-vertical?style=solid"/>
        [Description("Solid Ruler Vertical"), IconID("fas-ruler-vertical")]
        SolidRulerVertical = 0xf548,
        ///<summary>Solid Running</summary>
        ///<see href="https://fontawesome.com/icons/running?style=solid"/>
        [Description("Solid Running"), IconID("fas-running")]
        SolidRunning = 0xf70c,
        ///<summary>Solid Rupee Sign</summary>
        ///<see href="https://fontawesome.com/icons/rupee-sign?style=solid"/>
        [Description("Solid Rupee Sign"), IconID("fas-rupee-sign")]
        SolidRupeeSign = 0xf156,
        ///<summary>Solid Sad Cry</summary>
        ///<see href="https://fontawesome.com/icons/sad-cry?style=solid"/>
        [Description("Solid Sad Cry"), IconID("fas-sad-cry")]
        SolidSadCry = 0xf5b3,
        ///<summary>Solid Sad Tear</summary>
        ///<see href="https://fontawesome.com/icons/sad-tear?style=solid"/>
        [Description("Solid Sad Tear"), IconID("fas-sad-tear")]
        SolidSadTear = 0xf5b4,
        ///<summary>Solid Satellite</summary>
        ///<see href="https://fontawesome.com/icons/satellite?style=solid"/>
        [Description("Solid Satellite"), IconID("fas-satellite")]
        SolidSatellite = 0xf7bf,
        ///<summary>Solid Satellite Dish</summary>
        ///<see href="https://fontawesome.com/icons/satellite-dish?style=solid"/>
        [Description("Solid Satellite Dish"), IconID("fas-satellite-dish")]
        SolidSatelliteDish = 0xf7c0,
        ///<summary>Solid Save</summary>
        ///<see href="https://fontawesome.com/icons/save?style=solid"/>
        [Description("Solid Save"), IconID("fas-save")]
        SolidSave = 0xf0c7,
        ///<summary>Solid School</summary>
        ///<see href="https://fontawesome.com/icons/school?style=solid"/>
        [Description("Solid School"), IconID("fas-school")]
        SolidSchool = 0xf549,
        ///<summary>Solid Screwdriver</summary>
        ///<see href="https://fontawesome.com/icons/screwdriver?style=solid"/>
        [Description("Solid Screwdriver"), IconID("fas-screwdriver")]
        SolidScrewdriver = 0xf54a,
        ///<summary>Solid Scroll</summary>
        ///<see href="https://fontawesome.com/icons/scroll?style=solid"/>
        [Description("Solid Scroll"), IconID("fas-scroll")]
        SolidScroll = 0xf70e,
        ///<summary>Solid Sd Card</summary>
        ///<see href="https://fontawesome.com/icons/sd-card?style=solid"/>
        [Description("Solid Sd Card"), IconID("fas-sd-card")]
        SolidSdCard = 0xf7c2,
        ///<summary>Solid Search</summary>
        ///<see href="https://fontawesome.com/icons/search?style=solid"/>
        [Description("Solid Search"), IconID("fas-search")]
        SolidSearch = 0xf002,
        ///<summary>Solid Search Dollar</summary>
        ///<see href="https://fontawesome.com/icons/search-dollar?style=solid"/>
        [Description("Solid Search Dollar"), IconID("fas-search-dollar")]
        SolidSearchDollar = 0xf688,
        ///<summary>Solid Search Location</summary>
        ///<see href="https://fontawesome.com/icons/search-location?style=solid"/>
        [Description("Solid Search Location"), IconID("fas-search-location")]
        SolidSearchLocation = 0xf689,
        ///<summary>Solid Search Minus</summary>
        ///<see href="https://fontawesome.com/icons/search-minus?style=solid"/>
        [Description("Solid Search Minus"), IconID("fas-search-minus")]
        SolidSearchMinus = 0xf010,
        ///<summary>Solid Search Plus</summary>
        ///<see href="https://fontawesome.com/icons/search-plus?style=solid"/>
        [Description("Solid Search Plus"), IconID("fas-search-plus")]
        SolidSearchPlus = 0xf00e,
        ///<summary>Solid Seedling</summary>
        ///<see href="https://fontawesome.com/icons/seedling?style=solid"/>
        [Description("Solid Seedling"), IconID("fas-seedling")]
        SolidSeedling = 0xf4d8,
        ///<summary>Solid Server</summary>
        ///<see href="https://fontawesome.com/icons/server?style=solid"/>
        [Description("Solid Server"), IconID("fas-server")]
        SolidServer = 0xf233,
        ///<summary>Solid Shapes</summary>
        ///<see href="https://fontawesome.com/icons/shapes?style=solid"/>
        [Description("Solid Shapes"), IconID("fas-shapes")]
        SolidShapes = 0xf61f,
        ///<summary>Solid Share</summary>
        ///<see href="https://fontawesome.com/icons/share?style=solid"/>
        [Description("Solid Share"), IconID("fas-share")]
        SolidShare = 0xf064,
        ///<summary>Solid Share Alt</summary>
        ///<see href="https://fontawesome.com/icons/share-alt?style=solid"/>
        [Description("Solid Share Alt"), IconID("fas-share-alt")]
        SolidShareAlt = 0xf1e0,
        ///<summary>Solid Share Alt Square</summary>
        ///<see href="https://fontawesome.com/icons/share-alt-square?style=solid"/>
        [Description("Solid Share Alt Square"), IconID("fas-share-alt-square")]
        SolidShareAltSquare = 0xf1e1,
        ///<summary>Solid Share Square</summary>
        ///<see href="https://fontawesome.com/icons/share-square?style=solid"/>
        [Description("Solid Share Square"), IconID("fas-share-square")]
        SolidShareSquare = 0xf14d,
        ///<summary>Solid Shekel Sign</summary>
        ///<see href="https://fontawesome.com/icons/shekel-sign?style=solid"/>
        [Description("Solid Shekel Sign"), IconID("fas-shekel-sign")]
        SolidShekelSign = 0xf20b,
        ///<summary>Solid Shield Alt</summary>
        ///<see href="https://fontawesome.com/icons/shield-alt?style=solid"/>
        [Description("Solid Shield Alt"), IconID("fas-shield-alt")]
        SolidShieldAlt = 0xf3ed,
        ///<summary>Solid Shield Virus</summary>
        ///<see href="https://fontawesome.com/icons/shield-virus?style=solid"/>
        [Description("Solid Shield Virus"), IconID("fas-shield-virus")]
        SolidShieldVirus = 0xe06c,
        ///<summary>Solid Ship</summary>
        ///<see href="https://fontawesome.com/icons/ship?style=solid"/>
        [Description("Solid Ship"), IconID("fas-ship")]
        SolidShip = 0xf21a,
        ///<summary>Solid Shipping Fast</summary>
        ///<see href="https://fontawesome.com/icons/shipping-fast?style=solid"/>
        [Description("Solid Shipping Fast"), IconID("fas-shipping-fast")]
        SolidShippingFast = 0xf48b,
        ///<summary>Solid Shoe Prints</summary>
        ///<see href="https://fontawesome.com/icons/shoe-prints?style=solid"/>
        [Description("Solid Shoe Prints"), IconID("fas-shoe-prints")]
        SolidShoePrints = 0xf54b,
        ///<summary>Solid Shopping Bag</summary>
        ///<see href="https://fontawesome.com/icons/shopping-bag?style=solid"/>
        [Description("Solid Shopping Bag"), IconID("fas-shopping-bag")]
        SolidShoppingBag = 0xf290,
        ///<summary>Solid Shopping Basket</summary>
        ///<see href="https://fontawesome.com/icons/shopping-basket?style=solid"/>
        [Description("Solid Shopping Basket"), IconID("fas-shopping-basket")]
        SolidShoppingBasket = 0xf291,
        ///<summary>Solid Shopping Cart</summary>
        ///<see href="https://fontawesome.com/icons/shopping-cart?style=solid"/>
        [Description("Solid Shopping Cart"), IconID("fas-shopping-cart")]
        SolidShoppingCart = 0xf07a,
        ///<summary>Solid Shower</summary>
        ///<see href="https://fontawesome.com/icons/shower?style=solid"/>
        [Description("Solid Shower"), IconID("fas-shower")]
        SolidShower = 0xf2cc,
        ///<summary>Solid Shuttle Van</summary>
        ///<see href="https://fontawesome.com/icons/shuttle-van?style=solid"/>
        [Description("Solid Shuttle Van"), IconID("fas-shuttle-van")]
        SolidShuttleVan = 0xf5b6,
        ///<summary>Solid Sign</summary>
        ///<see href="https://fontawesome.com/icons/sign?style=solid"/>
        [Description("Solid Sign"), IconID("fas-sign")]
        SolidSign = 0xf4d9,
        ///<summary>Solid Sign In Alt</summary>
        ///<see href="https://fontawesome.com/icons/sign-in-alt?style=solid"/>
        [Description("Solid Sign In Alt"), IconID("fas-sign-in-alt")]
        SolidSignInAlt = 0xf2f6,
        ///<summary>Solid Sign Language</summary>
        ///<see href="https://fontawesome.com/icons/sign-language?style=solid"/>
        [Description("Solid Sign Language"), IconID("fas-sign-language")]
        SolidSignLanguage = 0xf2a7,
        ///<summary>Solid Sign Out Alt</summary>
        ///<see href="https://fontawesome.com/icons/sign-out-alt?style=solid"/>
        [Description("Solid Sign Out Alt"), IconID("fas-sign-out-alt")]
        SolidSignOutAlt = 0xf2f5,
        ///<summary>Solid Signal</summary>
        ///<see href="https://fontawesome.com/icons/signal?style=solid"/>
        [Description("Solid Signal"), IconID("fas-signal")]
        SolidSignal = 0xf012,
        ///<summary>Solid Signature</summary>
        ///<see href="https://fontawesome.com/icons/signature?style=solid"/>
        [Description("Solid Signature"), IconID("fas-signature")]
        SolidSignature = 0xf5b7,
        ///<summary>Solid Sim Card</summary>
        ///<see href="https://fontawesome.com/icons/sim-card?style=solid"/>
        [Description("Solid Sim Card"), IconID("fas-sim-card")]
        SolidSimCard = 0xf7c4,
        ///<summary>Solid Sink</summary>
        ///<see href="https://fontawesome.com/icons/sink?style=solid"/>
        [Description("Solid Sink"), IconID("fas-sink")]
        SolidSink = 0xe06d,
        ///<summary>Solid Sitemap</summary>
        ///<see href="https://fontawesome.com/icons/sitemap?style=solid"/>
        [Description("Solid Sitemap"), IconID("fas-sitemap")]
        SolidSitemap = 0xf0e8,
        ///<summary>Solid Skating</summary>
        ///<see href="https://fontawesome.com/icons/skating?style=solid"/>
        [Description("Solid Skating"), IconID("fas-skating")]
        SolidSkating = 0xf7c5,
        ///<summary>Solid Skiing</summary>
        ///<see href="https://fontawesome.com/icons/skiing?style=solid"/>
        [Description("Solid Skiing"), IconID("fas-skiing")]
        SolidSkiing = 0xf7c9,
        ///<summary>Solid Skiing Nordic</summary>
        ///<see href="https://fontawesome.com/icons/skiing-nordic?style=solid"/>
        [Description("Solid Skiing Nordic"), IconID("fas-skiing-nordic")]
        SolidSkiingNordic = 0xf7ca,
        ///<summary>Solid Skull</summary>
        ///<see href="https://fontawesome.com/icons/skull?style=solid"/>
        [Description("Solid Skull"), IconID("fas-skull")]
        SolidSkull = 0xf54c,
        ///<summary>Solid Skull Crossbones</summary>
        ///<see href="https://fontawesome.com/icons/skull-crossbones?style=solid"/>
        [Description("Solid Skull Crossbones"), IconID("fas-skull-crossbones")]
        SolidSkullCrossbones = 0xf714,
        ///<summary>Solid Slash</summary>
        ///<see href="https://fontawesome.com/icons/slash?style=solid"/>
        [Description("Solid Slash"), IconID("fas-slash")]
        SolidSlash = 0xf715,
        ///<summary>Solid Sleigh</summary>
        ///<see href="https://fontawesome.com/icons/sleigh?style=solid"/>
        [Description("Solid Sleigh"), IconID("fas-sleigh")]
        SolidSleigh = 0xf7cc,
        ///<summary>Solid Sliders H</summary>
        ///<see href="https://fontawesome.com/icons/sliders-h?style=solid"/>
        [Description("Solid Sliders H"), IconID("fas-sliders-h")]
        SolidSlidersH = 0xf1de,
        ///<summary>Solid Smile</summary>
        ///<see href="https://fontawesome.com/icons/smile?style=solid"/>
        [Description("Solid Smile"), IconID("fas-smile")]
        SolidSmile = 0xf118,
        ///<summary>Solid Smile Beam</summary>
        ///<see href="https://fontawesome.com/icons/smile-beam?style=solid"/>
        [Description("Solid Smile Beam"), IconID("fas-smile-beam")]
        SolidSmileBeam = 0xf5b8,
        ///<summary>Solid Smile Wink</summary>
        ///<see href="https://fontawesome.com/icons/smile-wink?style=solid"/>
        [Description("Solid Smile Wink"), IconID("fas-smile-wink")]
        SolidSmileWink = 0xf4da,
        ///<summary>Solid Smog</summary>
        ///<see href="https://fontawesome.com/icons/smog?style=solid"/>
        [Description("Solid Smog"), IconID("fas-smog")]
        SolidSmog = 0xf75f,
        ///<summary>Solid Smoking</summary>
        ///<see href="https://fontawesome.com/icons/smoking?style=solid"/>
        [Description("Solid Smoking"), IconID("fas-smoking")]
        SolidSmoking = 0xf48d,
        ///<summary>Solid Smoking Ban</summary>
        ///<see href="https://fontawesome.com/icons/smoking-ban?style=solid"/>
        [Description("Solid Smoking Ban"), IconID("fas-smoking-ban")]
        SolidSmokingBan = 0xf54d,
        ///<summary>Solid Sms</summary>
        ///<see href="https://fontawesome.com/icons/sms?style=solid"/>
        [Description("Solid Sms"), IconID("fas-sms")]
        SolidSms = 0xf7cd,
        ///<summary>Solid Snowboarding</summary>
        ///<see href="https://fontawesome.com/icons/snowboarding?style=solid"/>
        [Description("Solid Snowboarding"), IconID("fas-snowboarding")]
        SolidSnowboarding = 0xf7ce,
        ///<summary>Solid Snowflake</summary>
        ///<see href="https://fontawesome.com/icons/snowflake?style=solid"/>
        [Description("Solid Snowflake"), IconID("fas-snowflake")]
        SolidSnowflake = 0xf2dc,
        ///<summary>Solid Snowman</summary>
        ///<see href="https://fontawesome.com/icons/snowman?style=solid"/>
        [Description("Solid Snowman"), IconID("fas-snowman")]
        SolidSnowman = 0xf7d0,
        ///<summary>Solid Snowplow</summary>
        ///<see href="https://fontawesome.com/icons/snowplow?style=solid"/>
        [Description("Solid Snowplow"), IconID("fas-snowplow")]
        SolidSnowplow = 0xf7d2,
        ///<summary>Solid Soap</summary>
        ///<see href="https://fontawesome.com/icons/soap?style=solid"/>
        [Description("Solid Soap"), IconID("fas-soap")]
        SolidSoap = 0xe06e,
        ///<summary>Solid Socks</summary>
        ///<see href="https://fontawesome.com/icons/socks?style=solid"/>
        [Description("Solid Socks"), IconID("fas-socks")]
        SolidSocks = 0xf696,
        ///<summary>Solid Solar Panel</summary>
        ///<see href="https://fontawesome.com/icons/solar-panel?style=solid"/>
        [Description("Solid Solar Panel"), IconID("fas-solar-panel")]
        SolidSolarPanel = 0xf5ba,
        ///<summary>Solid Sort</summary>
        ///<see href="https://fontawesome.com/icons/sort?style=solid"/>
        [Description("Solid Sort"), IconID("fas-sort")]
        SolidSort = 0xf0dc,
        ///<summary>Solid Sort Alpha Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-down?style=solid"/>
        [Description("Solid Sort Alpha Down"), IconID("fas-sort-alpha-down")]
        SolidSortAlphaDown = 0xf15d,
        ///<summary>Solid Sort Alpha Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-down-alt?style=solid"/>
        [Description("Solid Sort Alpha Down Alt"), IconID("fas-sort-alpha-down-alt")]
        SolidSortAlphaDownAlt = 0xf881,
        ///<summary>Solid Sort Alpha Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-up?style=solid"/>
        [Description("Solid Sort Alpha Up"), IconID("fas-sort-alpha-up")]
        SolidSortAlphaUp = 0xf15e,
        ///<summary>Solid Sort Alpha Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-alpha-up-alt?style=solid"/>
        [Description("Solid Sort Alpha Up Alt"), IconID("fas-sort-alpha-up-alt")]
        SolidSortAlphaUpAlt = 0xf882,
        ///<summary>Solid Sort Amount Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-down?style=solid"/>
        [Description("Solid Sort Amount Down"), IconID("fas-sort-amount-down")]
        SolidSortAmountDown = 0xf160,
        ///<summary>Solid Sort Amount Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-down-alt?style=solid"/>
        [Description("Solid Sort Amount Down Alt"), IconID("fas-sort-amount-down-alt")]
        SolidSortAmountDownAlt = 0xf884,
        ///<summary>Solid Sort Amount Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-up?style=solid"/>
        [Description("Solid Sort Amount Up"), IconID("fas-sort-amount-up")]
        SolidSortAmountUp = 0xf161,
        ///<summary>Solid Sort Amount Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-amount-up-alt?style=solid"/>
        [Description("Solid Sort Amount Up Alt"), IconID("fas-sort-amount-up-alt")]
        SolidSortAmountUpAlt = 0xf885,
        ///<summary>Solid Sort Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-down?style=solid"/>
        [Description("Solid Sort Down"), IconID("fas-sort-down")]
        SolidSortDown = 0xf0dd,
        ///<summary>Solid Sort Numeric Down</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-down?style=solid"/>
        [Description("Solid Sort Numeric Down"), IconID("fas-sort-numeric-down")]
        SolidSortNumericDown = 0xf162,
        ///<summary>Solid Sort Numeric Down Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-down-alt?style=solid"/>
        [Description("Solid Sort Numeric Down Alt"), IconID("fas-sort-numeric-down-alt")]
        SolidSortNumericDownAlt = 0xf886,
        ///<summary>Solid Sort Numeric Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-up?style=solid"/>
        [Description("Solid Sort Numeric Up"), IconID("fas-sort-numeric-up")]
        SolidSortNumericUp = 0xf163,
        ///<summary>Solid Sort Numeric Up Alt</summary>
        ///<see href="https://fontawesome.com/icons/sort-numeric-up-alt?style=solid"/>
        [Description("Solid Sort Numeric Up Alt"), IconID("fas-sort-numeric-up-alt")]
        SolidSortNumericUpAlt = 0xf887,
        ///<summary>Solid Sort Up</summary>
        ///<see href="https://fontawesome.com/icons/sort-up?style=solid"/>
        [Description("Solid Sort Up"), IconID("fas-sort-up")]
        SolidSortUp = 0xf0de,
        ///<summary>Solid Spa</summary>
        ///<see href="https://fontawesome.com/icons/spa?style=solid"/>
        [Description("Solid Spa"), IconID("fas-spa")]
        SolidSpa = 0xf5bb,
        ///<summary>Solid Space Shuttle</summary>
        ///<see href="https://fontawesome.com/icons/space-shuttle?style=solid"/>
        [Description("Solid Space Shuttle"), IconID("fas-space-shuttle")]
        SolidSpaceShuttle = 0xf197,
        ///<summary>Solid Spell Check</summary>
        ///<see href="https://fontawesome.com/icons/spell-check?style=solid"/>
        [Description("Solid Spell Check"), IconID("fas-spell-check")]
        SolidSpellCheck = 0xf891,
        ///<summary>Solid Spider</summary>
        ///<see href="https://fontawesome.com/icons/spider?style=solid"/>
        [Description("Solid Spider"), IconID("fas-spider")]
        SolidSpider = 0xf717,
        ///<summary>Solid Spinner</summary>
        ///<see href="https://fontawesome.com/icons/spinner?style=solid"/>
        [Description("Solid Spinner"), IconID("fas-spinner")]
        SolidSpinner = 0xf110,
        ///<summary>Solid Splotch</summary>
        ///<see href="https://fontawesome.com/icons/splotch?style=solid"/>
        [Description("Solid Splotch"), IconID("fas-splotch")]
        SolidSplotch = 0xf5bc,
        ///<summary>Solid Spray Can</summary>
        ///<see href="https://fontawesome.com/icons/spray-can?style=solid"/>
        [Description("Solid Spray Can"), IconID("fas-spray-can")]
        SolidSprayCan = 0xf5bd,
        ///<summary>Solid Square</summary>
        ///<see href="https://fontawesome.com/icons/square?style=solid"/>
        [Description("Solid Square"), IconID("fas-square")]
        SolidSquare = 0xf0c8,
        ///<summary>Solid Square Full</summary>
        ///<see href="https://fontawesome.com/icons/square-full?style=solid"/>
        [Description("Solid Square Full"), IconID("fas-square-full")]
        SolidSquareFull = 0xf45c,
        ///<summary>Solid Square Root Alt</summary>
        ///<see href="https://fontawesome.com/icons/square-root-alt?style=solid"/>
        [Description("Solid Square Root Alt"), IconID("fas-square-root-alt")]
        SolidSquareRootAlt = 0xf698,
        ///<summary>Solid Stamp</summary>
        ///<see href="https://fontawesome.com/icons/stamp?style=solid"/>
        [Description("Solid Stamp"), IconID("fas-stamp")]
        SolidStamp = 0xf5bf,
        ///<summary>Solid Star</summary>
        ///<see href="https://fontawesome.com/icons/star?style=solid"/>
        [Description("Solid Star"), IconID("fas-star")]
        SolidStar = 0xf005,
        ///<summary>Solid Star And Crescent</summary>
        ///<see href="https://fontawesome.com/icons/star-and-crescent?style=solid"/>
        [Description("Solid Star And Crescent"), IconID("fas-star-and-crescent")]
        SolidStarAndCrescent = 0xf699,
        ///<summary>Solid Star Half</summary>
        ///<see href="https://fontawesome.com/icons/star-half?style=solid"/>
        [Description("Solid Star Half"), IconID("fas-star-half")]
        SolidStarHalf = 0xf089,
        ///<summary>Solid Star Half Alt</summary>
        ///<see href="https://fontawesome.com/icons/star-half-alt?style=solid"/>
        [Description("Solid Star Half Alt"), IconID("fas-star-half-alt")]
        SolidStarHalfAlt = 0xf5c0,
        ///<summary>Solid Star Of David</summary>
        ///<see href="https://fontawesome.com/icons/star-of-david?style=solid"/>
        [Description("Solid Star Of David"), IconID("fas-star-of-david")]
        SolidStarOfDavid = 0xf69a,
        ///<summary>Solid Star Of Life</summary>
        ///<see href="https://fontawesome.com/icons/star-of-life?style=solid"/>
        [Description("Solid Star Of Life"), IconID("fas-star-of-life")]
        SolidStarOfLife = 0xf621,
        ///<summary>Solid Step Backward</summary>
        ///<see href="https://fontawesome.com/icons/step-backward?style=solid"/>
        [Description("Solid Step Backward"), IconID("fas-step-backward")]
        SolidStepBackward = 0xf048,
        ///<summary>Solid Step Forward</summary>
        ///<see href="https://fontawesome.com/icons/step-forward?style=solid"/>
        [Description("Solid Step Forward"), IconID("fas-step-forward")]
        SolidStepForward = 0xf051,
        ///<summary>Solid Stethoscope</summary>
        ///<see href="https://fontawesome.com/icons/stethoscope?style=solid"/>
        [Description("Solid Stethoscope"), IconID("fas-stethoscope")]
        SolidStethoscope = 0xf0f1,
        ///<summary>Solid Sticky Note</summary>
        ///<see href="https://fontawesome.com/icons/sticky-note?style=solid"/>
        [Description("Solid Sticky Note"), IconID("fas-sticky-note")]
        SolidStickyNote = 0xf249,
        ///<summary>Solid Stop</summary>
        ///<see href="https://fontawesome.com/icons/stop?style=solid"/>
        [Description("Solid Stop"), IconID("fas-stop")]
        SolidStop = 0xf04d,
        ///<summary>Solid Stop Circle</summary>
        ///<see href="https://fontawesome.com/icons/stop-circle?style=solid"/>
        [Description("Solid Stop Circle"), IconID("fas-stop-circle")]
        SolidStopCircle = 0xf28d,
        ///<summary>Solid Stopwatch</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch?style=solid"/>
        [Description("Solid Stopwatch"), IconID("fas-stopwatch")]
        SolidStopwatch = 0xf2f2,
        ///<summary>Solid Stopwatch 20</summary>
        ///<see href="https://fontawesome.com/icons/stopwatch-20?style=solid"/>
        [Description("Solid Stopwatch 20"), IconID("fas-stopwatch-20")]
        SolidStopwatch20 = 0xe06f,
        ///<summary>Solid Store</summary>
        ///<see href="https://fontawesome.com/icons/store?style=solid"/>
        [Description("Solid Store"), IconID("fas-store")]
        SolidStore = 0xf54e,
        ///<summary>Solid Store Alt</summary>
        ///<see href="https://fontawesome.com/icons/store-alt?style=solid"/>
        [Description("Solid Store Alt"), IconID("fas-store-alt")]
        SolidStoreAlt = 0xf54f,
        ///<summary>Solid Store Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/store-alt-slash?style=solid"/>
        [Description("Solid Store Alt Slash"), IconID("fas-store-alt-slash")]
        SolidStoreAltSlash = 0xe070,
        ///<summary>Solid Store Slash</summary>
        ///<see href="https://fontawesome.com/icons/store-slash?style=solid"/>
        [Description("Solid Store Slash"), IconID("fas-store-slash")]
        SolidStoreSlash = 0xe071,
        ///<summary>Solid Stream</summary>
        ///<see href="https://fontawesome.com/icons/stream?style=solid"/>
        [Description("Solid Stream"), IconID("fas-stream")]
        SolidStream = 0xf550,
        ///<summary>Solid Street View</summary>
        ///<see href="https://fontawesome.com/icons/street-view?style=solid"/>
        [Description("Solid Street View"), IconID("fas-street-view")]
        SolidStreetView = 0xf21d,
        ///<summary>Solid Strikethrough</summary>
        ///<see href="https://fontawesome.com/icons/strikethrough?style=solid"/>
        [Description("Solid Strikethrough"), IconID("fas-strikethrough")]
        SolidStrikethrough = 0xf0cc,
        ///<summary>Solid Stroopwafel</summary>
        ///<see href="https://fontawesome.com/icons/stroopwafel?style=solid"/>
        [Description("Solid Stroopwafel"), IconID("fas-stroopwafel")]
        SolidStroopwafel = 0xf551,
        ///<summary>Solid Subscript</summary>
        ///<see href="https://fontawesome.com/icons/subscript?style=solid"/>
        [Description("Solid Subscript"), IconID("fas-subscript")]
        SolidSubscript = 0xf12c,
        ///<summary>Solid Subway</summary>
        ///<see href="https://fontawesome.com/icons/subway?style=solid"/>
        [Description("Solid Subway"), IconID("fas-subway")]
        SolidSubway = 0xf239,
        ///<summary>Solid Suitcase</summary>
        ///<see href="https://fontawesome.com/icons/suitcase?style=solid"/>
        [Description("Solid Suitcase"), IconID("fas-suitcase")]
        SolidSuitcase = 0xf0f2,
        ///<summary>Solid Suitcase Rolling</summary>
        ///<see href="https://fontawesome.com/icons/suitcase-rolling?style=solid"/>
        [Description("Solid Suitcase Rolling"), IconID("fas-suitcase-rolling")]
        SolidSuitcaseRolling = 0xf5c1,
        ///<summary>Solid Sun</summary>
        ///<see href="https://fontawesome.com/icons/sun?style=solid"/>
        [Description("Solid Sun"), IconID("fas-sun")]
        SolidSun = 0xf185,
        ///<summary>Solid Superscript</summary>
        ///<see href="https://fontawesome.com/icons/superscript?style=solid"/>
        [Description("Solid Superscript"), IconID("fas-superscript")]
        SolidSuperscript = 0xf12b,
        ///<summary>Solid Surprise</summary>
        ///<see href="https://fontawesome.com/icons/surprise?style=solid"/>
        [Description("Solid Surprise"), IconID("fas-surprise")]
        SolidSurprise = 0xf5c2,
        ///<summary>Solid Swatchbook</summary>
        ///<see href="https://fontawesome.com/icons/swatchbook?style=solid"/>
        [Description("Solid Swatchbook"), IconID("fas-swatchbook")]
        SolidSwatchbook = 0xf5c3,
        ///<summary>Solid Swimmer</summary>
        ///<see href="https://fontawesome.com/icons/swimmer?style=solid"/>
        [Description("Solid Swimmer"), IconID("fas-swimmer")]
        SolidSwimmer = 0xf5c4,
        ///<summary>Solid Swimming Pool</summary>
        ///<see href="https://fontawesome.com/icons/swimming-pool?style=solid"/>
        [Description("Solid Swimming Pool"), IconID("fas-swimming-pool")]
        SolidSwimmingPool = 0xf5c5,
        ///<summary>Solid Synagogue</summary>
        ///<see href="https://fontawesome.com/icons/synagogue?style=solid"/>
        [Description("Solid Synagogue"), IconID("fas-synagogue")]
        SolidSynagogue = 0xf69b,
        ///<summary>Solid Sync</summary>
        ///<see href="https://fontawesome.com/icons/sync?style=solid"/>
        [Description("Solid Sync"), IconID("fas-sync")]
        SolidSync = 0xf021,
        ///<summary>Solid Sync Alt</summary>
        ///<see href="https://fontawesome.com/icons/sync-alt?style=solid"/>
        [Description("Solid Sync Alt"), IconID("fas-sync-alt")]
        SolidSyncAlt = 0xf2f1,
        ///<summary>Solid Syringe</summary>
        ///<see href="https://fontawesome.com/icons/syringe?style=solid"/>
        [Description("Solid Syringe"), IconID("fas-syringe")]
        SolidSyringe = 0xf48e,
        ///<summary>Solid Table</summary>
        ///<see href="https://fontawesome.com/icons/table?style=solid"/>
        [Description("Solid Table"), IconID("fas-table")]
        SolidTable = 0xf0ce,
        ///<summary>Solid Table Tennis</summary>
        ///<see href="https://fontawesome.com/icons/table-tennis?style=solid"/>
        [Description("Solid Table Tennis"), IconID("fas-table-tennis")]
        SolidTableTennis = 0xf45d,
        ///<summary>Solid Tablet</summary>
        ///<see href="https://fontawesome.com/icons/tablet?style=solid"/>
        [Description("Solid Tablet"), IconID("fas-tablet")]
        SolidTablet = 0xf10a,
        ///<summary>Solid Tablet Alt</summary>
        ///<see href="https://fontawesome.com/icons/tablet-alt?style=solid"/>
        [Description("Solid Tablet Alt"), IconID("fas-tablet-alt")]
        SolidTabletAlt = 0xf3fa,
        ///<summary>Solid Tablets</summary>
        ///<see href="https://fontawesome.com/icons/tablets?style=solid"/>
        [Description("Solid Tablets"), IconID("fas-tablets")]
        SolidTablets = 0xf490,
        ///<summary>Solid Tachometer Alt</summary>
        ///<see href="https://fontawesome.com/icons/tachometer-alt?style=solid"/>
        [Description("Solid Tachometer Alt"), IconID("fas-tachometer-alt")]
        SolidTachometerAlt = 0xf3fd,
        ///<summary>Solid Tag</summary>
        ///<see href="https://fontawesome.com/icons/tag?style=solid"/>
        [Description("Solid Tag"), IconID("fas-tag")]
        SolidTag = 0xf02b,
        ///<summary>Solid Tags</summary>
        ///<see href="https://fontawesome.com/icons/tags?style=solid"/>
        [Description("Solid Tags"), IconID("fas-tags")]
        SolidTags = 0xf02c,
        ///<summary>Solid Tape</summary>
        ///<see href="https://fontawesome.com/icons/tape?style=solid"/>
        [Description("Solid Tape"), IconID("fas-tape")]
        SolidTape = 0xf4db,
        ///<summary>Solid Tasks</summary>
        ///<see href="https://fontawesome.com/icons/tasks?style=solid"/>
        [Description("Solid Tasks"), IconID("fas-tasks")]
        SolidTasks = 0xf0ae,
        ///<summary>Solid Taxi</summary>
        ///<see href="https://fontawesome.com/icons/taxi?style=solid"/>
        [Description("Solid Taxi"), IconID("fas-taxi")]
        SolidTaxi = 0xf1ba,
        ///<summary>Solid Teeth</summary>
        ///<see href="https://fontawesome.com/icons/teeth?style=solid"/>
        [Description("Solid Teeth"), IconID("fas-teeth")]
        SolidTeeth = 0xf62e,
        ///<summary>Solid Teeth Open</summary>
        ///<see href="https://fontawesome.com/icons/teeth-open?style=solid"/>
        [Description("Solid Teeth Open"), IconID("fas-teeth-open")]
        SolidTeethOpen = 0xf62f,
        ///<summary>Solid Temperature High</summary>
        ///<see href="https://fontawesome.com/icons/temperature-high?style=solid"/>
        [Description("Solid Temperature High"), IconID("fas-temperature-high")]
        SolidTemperatureHigh = 0xf769,
        ///<summary>Solid Temperature Low</summary>
        ///<see href="https://fontawesome.com/icons/temperature-low?style=solid"/>
        [Description("Solid Temperature Low"), IconID("fas-temperature-low")]
        SolidTemperatureLow = 0xf76b,
        ///<summary>Solid Tenge</summary>
        ///<see href="https://fontawesome.com/icons/tenge?style=solid"/>
        [Description("Solid Tenge"), IconID("fas-tenge")]
        SolidTenge = 0xf7d7,
        ///<summary>Solid Terminal</summary>
        ///<see href="https://fontawesome.com/icons/terminal?style=solid"/>
        [Description("Solid Terminal"), IconID("fas-terminal")]
        SolidTerminal = 0xf120,
        ///<summary>Solid Text Height</summary>
        ///<see href="https://fontawesome.com/icons/text-height?style=solid"/>
        [Description("Solid Text Height"), IconID("fas-text-height")]
        SolidTextHeight = 0xf034,
        ///<summary>Solid Text Width</summary>
        ///<see href="https://fontawesome.com/icons/text-width?style=solid"/>
        [Description("Solid Text Width"), IconID("fas-text-width")]
        SolidTextWidth = 0xf035,
        ///<summary>Solid Th</summary>
        ///<see href="https://fontawesome.com/icons/th?style=solid"/>
        [Description("Solid Th"), IconID("fas-th")]
        SolidTh = 0xf00a,
        ///<summary>Solid Th Large</summary>
        ///<see href="https://fontawesome.com/icons/th-large?style=solid"/>
        [Description("Solid Th Large"), IconID("fas-th-large")]
        SolidThLarge = 0xf009,
        ///<summary>Solid Th List</summary>
        ///<see href="https://fontawesome.com/icons/th-list?style=solid"/>
        [Description("Solid Th List"), IconID("fas-th-list")]
        SolidThList = 0xf00b,
        ///<summary>Solid Theater Masks</summary>
        ///<see href="https://fontawesome.com/icons/theater-masks?style=solid"/>
        [Description("Solid Theater Masks"), IconID("fas-theater-masks")]
        SolidTheaterMasks = 0xf630,
        ///<summary>Solid Thermometer</summary>
        ///<see href="https://fontawesome.com/icons/thermometer?style=solid"/>
        [Description("Solid Thermometer"), IconID("fas-thermometer")]
        SolidThermometer = 0xf491,
        ///<summary>Solid Thermometer Empty</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-empty?style=solid"/>
        [Description("Solid Thermometer Empty"), IconID("fas-thermometer-empty")]
        SolidThermometerEmpty = 0xf2cb,
        ///<summary>Solid Thermometer Full</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-full?style=solid"/>
        [Description("Solid Thermometer Full"), IconID("fas-thermometer-full")]
        SolidThermometerFull = 0xf2c7,
        ///<summary>Solid Thermometer Half</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-half?style=solid"/>
        [Description("Solid Thermometer Half"), IconID("fas-thermometer-half")]
        SolidThermometerHalf = 0xf2c9,
        ///<summary>Solid Thermometer Quarter</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-quarter?style=solid"/>
        [Description("Solid Thermometer Quarter"), IconID("fas-thermometer-quarter")]
        SolidThermometerQuarter = 0xf2ca,
        ///<summary>Solid Thermometer Three Quarters</summary>
        ///<see href="https://fontawesome.com/icons/thermometer-three-quarters?style=solid"/>
        [Description("Solid Thermometer Three Quarters"), IconID("fas-thermometer-three-quarters")]
        SolidThermometerThreeQuarters = 0xf2c8,
        ///<summary>Solid Thumbs Down</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-down?style=solid"/>
        [Description("Solid Thumbs Down"), IconID("fas-thumbs-down")]
        SolidThumbsDown = 0xf165,
        ///<summary>Solid Thumbs Up</summary>
        ///<see href="https://fontawesome.com/icons/thumbs-up?style=solid"/>
        [Description("Solid Thumbs Up"), IconID("fas-thumbs-up")]
        SolidThumbsUp = 0xf164,
        ///<summary>Solid Thumbtack</summary>
        ///<see href="https://fontawesome.com/icons/thumbtack?style=solid"/>
        [Description("Solid Thumbtack"), IconID("fas-thumbtack")]
        SolidThumbtack = 0xf08d,
        ///<summary>Solid Ticket Alt</summary>
        ///<see href="https://fontawesome.com/icons/ticket-alt?style=solid"/>
        [Description("Solid Ticket Alt"), IconID("fas-ticket-alt")]
        SolidTicketAlt = 0xf3ff,
        ///<summary>Solid Times</summary>
        ///<see href="https://fontawesome.com/icons/times?style=solid"/>
        [Description("Solid Times"), IconID("fas-times")]
        SolidTimes = 0xf00d,
        ///<summary>Solid Times Circle</summary>
        ///<see href="https://fontawesome.com/icons/times-circle?style=solid"/>
        [Description("Solid Times Circle"), IconID("fas-times-circle")]
        SolidTimesCircle = 0xf057,
        ///<summary>Solid Tint</summary>
        ///<see href="https://fontawesome.com/icons/tint?style=solid"/>
        [Description("Solid Tint"), IconID("fas-tint")]
        SolidTint = 0xf043,
        ///<summary>Solid Tint Slash</summary>
        ///<see href="https://fontawesome.com/icons/tint-slash?style=solid"/>
        [Description("Solid Tint Slash"), IconID("fas-tint-slash")]
        SolidTintSlash = 0xf5c7,
        ///<summary>Solid Tired</summary>
        ///<see href="https://fontawesome.com/icons/tired?style=solid"/>
        [Description("Solid Tired"), IconID("fas-tired")]
        SolidTired = 0xf5c8,
        ///<summary>Solid Toggle Off</summary>
        ///<see href="https://fontawesome.com/icons/toggle-off?style=solid"/>
        [Description("Solid Toggle Off"), IconID("fas-toggle-off")]
        SolidToggleOff = 0xf204,
        ///<summary>Solid Toggle On</summary>
        ///<see href="https://fontawesome.com/icons/toggle-on?style=solid"/>
        [Description("Solid Toggle On"), IconID("fas-toggle-on")]
        SolidToggleOn = 0xf205,
        ///<summary>Solid Toilet</summary>
        ///<see href="https://fontawesome.com/icons/toilet?style=solid"/>
        [Description("Solid Toilet"), IconID("fas-toilet")]
        SolidToilet = 0xf7d8,
        ///<summary>Solid Toilet Paper</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper?style=solid"/>
        [Description("Solid Toilet Paper"), IconID("fas-toilet-paper")]
        SolidToiletPaper = 0xf71e,
        ///<summary>Solid Toilet Paper Slash</summary>
        ///<see href="https://fontawesome.com/icons/toilet-paper-slash?style=solid"/>
        [Description("Solid Toilet Paper Slash"), IconID("fas-toilet-paper-slash")]
        SolidToiletPaperSlash = 0xe072,
        ///<summary>Solid Toolbox</summary>
        ///<see href="https://fontawesome.com/icons/toolbox?style=solid"/>
        [Description("Solid Toolbox"), IconID("fas-toolbox")]
        SolidToolbox = 0xf552,
        ///<summary>Solid Tools</summary>
        ///<see href="https://fontawesome.com/icons/tools?style=solid"/>
        [Description("Solid Tools"), IconID("fas-tools")]
        SolidTools = 0xf7d9,
        ///<summary>Solid Tooth</summary>
        ///<see href="https://fontawesome.com/icons/tooth?style=solid"/>
        [Description("Solid Tooth"), IconID("fas-tooth")]
        SolidTooth = 0xf5c9,
        ///<summary>Solid Torah</summary>
        ///<see href="https://fontawesome.com/icons/torah?style=solid"/>
        [Description("Solid Torah"), IconID("fas-torah")]
        SolidTorah = 0xf6a0,
        ///<summary>Solid Torii Gate</summary>
        ///<see href="https://fontawesome.com/icons/torii-gate?style=solid"/>
        [Description("Solid Torii Gate"), IconID("fas-torii-gate")]
        SolidToriiGate = 0xf6a1,
        ///<summary>Solid Tractor</summary>
        ///<see href="https://fontawesome.com/icons/tractor?style=solid"/>
        [Description("Solid Tractor"), IconID("fas-tractor")]
        SolidTractor = 0xf722,
        ///<summary>Solid Trademark</summary>
        ///<see href="https://fontawesome.com/icons/trademark?style=solid"/>
        [Description("Solid Trademark"), IconID("fas-trademark")]
        SolidTrademark = 0xf25c,
        ///<summary>Solid Traffic Light</summary>
        ///<see href="https://fontawesome.com/icons/traffic-light?style=solid"/>
        [Description("Solid Traffic Light"), IconID("fas-traffic-light")]
        SolidTrafficLight = 0xf637,
        ///<summary>Solid Trailer</summary>
        ///<see href="https://fontawesome.com/icons/trailer?style=solid"/>
        [Description("Solid Trailer"), IconID("fas-trailer")]
        SolidTrailer = 0xe041,
        ///<summary>Solid Train</summary>
        ///<see href="https://fontawesome.com/icons/train?style=solid"/>
        [Description("Solid Train"), IconID("fas-train")]
        SolidTrain = 0xf238,
        ///<summary>Solid Tram</summary>
        ///<see href="https://fontawesome.com/icons/tram?style=solid"/>
        [Description("Solid Tram"), IconID("fas-tram")]
        SolidTram = 0xf7da,
        ///<summary>Solid Transgender</summary>
        ///<see href="https://fontawesome.com/icons/transgender?style=solid"/>
        [Description("Solid Transgender"), IconID("fas-transgender")]
        SolidTransgender = 0xf224,
        ///<summary>Solid Transgender Alt</summary>
        ///<see href="https://fontawesome.com/icons/transgender-alt?style=solid"/>
        [Description("Solid Transgender Alt"), IconID("fas-transgender-alt")]
        SolidTransgenderAlt = 0xf225,
        ///<summary>Solid Trash</summary>
        ///<see href="https://fontawesome.com/icons/trash?style=solid"/>
        [Description("Solid Trash"), IconID("fas-trash")]
        SolidTrash = 0xf1f8,
        ///<summary>Solid Trash Alt</summary>
        ///<see href="https://fontawesome.com/icons/trash-alt?style=solid"/>
        [Description("Solid Trash Alt"), IconID("fas-trash-alt")]
        SolidTrashAlt = 0xf2ed,
        ///<summary>Solid Trash Restore</summary>
        ///<see href="https://fontawesome.com/icons/trash-restore?style=solid"/>
        [Description("Solid Trash Restore"), IconID("fas-trash-restore")]
        SolidTrashRestore = 0xf829,
        ///<summary>Solid Trash Restore Alt</summary>
        ///<see href="https://fontawesome.com/icons/trash-restore-alt?style=solid"/>
        [Description("Solid Trash Restore Alt"), IconID("fas-trash-restore-alt")]
        SolidTrashRestoreAlt = 0xf82a,
        ///<summary>Solid Tree</summary>
        ///<see href="https://fontawesome.com/icons/tree?style=solid"/>
        [Description("Solid Tree"), IconID("fas-tree")]
        SolidTree = 0xf1bb,
        ///<summary>Solid Trophy</summary>
        ///<see href="https://fontawesome.com/icons/trophy?style=solid"/>
        [Description("Solid Trophy"), IconID("fas-trophy")]
        SolidTrophy = 0xf091,
        ///<summary>Solid Truck</summary>
        ///<see href="https://fontawesome.com/icons/truck?style=solid"/>
        [Description("Solid Truck"), IconID("fas-truck")]
        SolidTruck = 0xf0d1,
        ///<summary>Solid Truck Loading</summary>
        ///<see href="https://fontawesome.com/icons/truck-loading?style=solid"/>
        [Description("Solid Truck Loading"), IconID("fas-truck-loading")]
        SolidTruckLoading = 0xf4de,
        ///<summary>Solid Truck Monster</summary>
        ///<see href="https://fontawesome.com/icons/truck-monster?style=solid"/>
        [Description("Solid Truck Monster"), IconID("fas-truck-monster")]
        SolidTruckMonster = 0xf63b,
        ///<summary>Solid Truck Moving</summary>
        ///<see href="https://fontawesome.com/icons/truck-moving?style=solid"/>
        [Description("Solid Truck Moving"), IconID("fas-truck-moving")]
        SolidTruckMoving = 0xf4df,
        ///<summary>Solid Truck Pickup</summary>
        ///<see href="https://fontawesome.com/icons/truck-pickup?style=solid"/>
        [Description("Solid Truck Pickup"), IconID("fas-truck-pickup")]
        SolidTruckPickup = 0xf63c,
        ///<summary>Solid Tshirt</summary>
        ///<see href="https://fontawesome.com/icons/tshirt?style=solid"/>
        [Description("Solid Tshirt"), IconID("fas-tshirt")]
        SolidTshirt = 0xf553,
        ///<summary>Solid Tty</summary>
        ///<see href="https://fontawesome.com/icons/tty?style=solid"/>
        [Description("Solid Tty"), IconID("fas-tty")]
        SolidTty = 0xf1e4,
        ///<summary>Solid Tv</summary>
        ///<see href="https://fontawesome.com/icons/tv?style=solid"/>
        [Description("Solid Tv"), IconID("fas-tv")]
        SolidTv = 0xf26c,
        ///<summary>Solid Umbrella</summary>
        ///<see href="https://fontawesome.com/icons/umbrella?style=solid"/>
        [Description("Solid Umbrella"), IconID("fas-umbrella")]
        SolidUmbrella = 0xf0e9,
        ///<summary>Solid Umbrella Beach</summary>
        ///<see href="https://fontawesome.com/icons/umbrella-beach?style=solid"/>
        [Description("Solid Umbrella Beach"), IconID("fas-umbrella-beach")]
        SolidUmbrellaBeach = 0xf5ca,
        ///<summary>Solid Underline</summary>
        ///<see href="https://fontawesome.com/icons/underline?style=solid"/>
        [Description("Solid Underline"), IconID("fas-underline")]
        SolidUnderline = 0xf0cd,
        ///<summary>Solid Undo</summary>
        ///<see href="https://fontawesome.com/icons/undo?style=solid"/>
        [Description("Solid Undo"), IconID("fas-undo")]
        SolidUndo = 0xf0e2,
        ///<summary>Solid Undo Alt</summary>
        ///<see href="https://fontawesome.com/icons/undo-alt?style=solid"/>
        [Description("Solid Undo Alt"), IconID("fas-undo-alt")]
        SolidUndoAlt = 0xf2ea,
        ///<summary>Solid Universal Access</summary>
        ///<see href="https://fontawesome.com/icons/universal-access?style=solid"/>
        [Description("Solid Universal Access"), IconID("fas-universal-access")]
        SolidUniversalAccess = 0xf29a,
        ///<summary>Solid University</summary>
        ///<see href="https://fontawesome.com/icons/university?style=solid"/>
        [Description("Solid University"), IconID("fas-university")]
        SolidUniversity = 0xf19c,
        ///<summary>Solid Unlink</summary>
        ///<see href="https://fontawesome.com/icons/unlink?style=solid"/>
        [Description("Solid Unlink"), IconID("fas-unlink")]
        SolidUnlink = 0xf127,
        ///<summary>Solid Unlock</summary>
        ///<see href="https://fontawesome.com/icons/unlock?style=solid"/>
        [Description("Solid Unlock"), IconID("fas-unlock")]
        SolidUnlock = 0xf09c,
        ///<summary>Solid Unlock Alt</summary>
        ///<see href="https://fontawesome.com/icons/unlock-alt?style=solid"/>
        [Description("Solid Unlock Alt"), IconID("fas-unlock-alt")]
        SolidUnlockAlt = 0xf13e,
        ///<summary>Solid Upload</summary>
        ///<see href="https://fontawesome.com/icons/upload?style=solid"/>
        [Description("Solid Upload"), IconID("fas-upload")]
        SolidUpload = 0xf093,
        ///<summary>Solid User</summary>
        ///<see href="https://fontawesome.com/icons/user?style=solid"/>
        [Description("Solid User"), IconID("fas-user")]
        SolidUser = 0xf007,
        ///<summary>Solid User Alt</summary>
        ///<see href="https://fontawesome.com/icons/user-alt?style=solid"/>
        [Description("Solid User Alt"), IconID("fas-user-alt")]
        SolidUserAlt = 0xf406,
        ///<summary>Solid User Alt Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-alt-slash?style=solid"/>
        [Description("Solid User Alt Slash"), IconID("fas-user-alt-slash")]
        SolidUserAltSlash = 0xf4fa,
        ///<summary>Solid User Astronaut</summary>
        ///<see href="https://fontawesome.com/icons/user-astronaut?style=solid"/>
        [Description("Solid User Astronaut"), IconID("fas-user-astronaut")]
        SolidUserAstronaut = 0xf4fb,
        ///<summary>Solid User Check</summary>
        ///<see href="https://fontawesome.com/icons/user-check?style=solid"/>
        [Description("Solid User Check"), IconID("fas-user-check")]
        SolidUserCheck = 0xf4fc,
        ///<summary>Solid User Circle</summary>
        ///<see href="https://fontawesome.com/icons/user-circle?style=solid"/>
        [Description("Solid User Circle"), IconID("fas-user-circle")]
        SolidUserCircle = 0xf2bd,
        ///<summary>Solid User Clock</summary>
        ///<see href="https://fontawesome.com/icons/user-clock?style=solid"/>
        [Description("Solid User Clock"), IconID("fas-user-clock")]
        SolidUserClock = 0xf4fd,
        ///<summary>Solid User Cog</summary>
        ///<see href="https://fontawesome.com/icons/user-cog?style=solid"/>
        [Description("Solid User Cog"), IconID("fas-user-cog")]
        SolidUserCog = 0xf4fe,
        ///<summary>Solid User Edit</summary>
        ///<see href="https://fontawesome.com/icons/user-edit?style=solid"/>
        [Description("Solid User Edit"), IconID("fas-user-edit")]
        SolidUserEdit = 0xf4ff,
        ///<summary>Solid User Friends</summary>
        ///<see href="https://fontawesome.com/icons/user-friends?style=solid"/>
        [Description("Solid User Friends"), IconID("fas-user-friends")]
        SolidUserFriends = 0xf500,
        ///<summary>Solid User Graduate</summary>
        ///<see href="https://fontawesome.com/icons/user-graduate?style=solid"/>
        [Description("Solid User Graduate"), IconID("fas-user-graduate")]
        SolidUserGraduate = 0xf501,
        ///<summary>Solid User Injured</summary>
        ///<see href="https://fontawesome.com/icons/user-injured?style=solid"/>
        [Description("Solid User Injured"), IconID("fas-user-injured")]
        SolidUserInjured = 0xf728,
        ///<summary>Solid User Lock</summary>
        ///<see href="https://fontawesome.com/icons/user-lock?style=solid"/>
        [Description("Solid User Lock"), IconID("fas-user-lock")]
        SolidUserLock = 0xf502,
        ///<summary>Solid User Md</summary>
        ///<see href="https://fontawesome.com/icons/user-md?style=solid"/>
        [Description("Solid User Md"), IconID("fas-user-md")]
        SolidUserMd = 0xf0f0,
        ///<summary>Solid User Minus</summary>
        ///<see href="https://fontawesome.com/icons/user-minus?style=solid"/>
        [Description("Solid User Minus"), IconID("fas-user-minus")]
        SolidUserMinus = 0xf503,
        ///<summary>Solid User Ninja</summary>
        ///<see href="https://fontawesome.com/icons/user-ninja?style=solid"/>
        [Description("Solid User Ninja"), IconID("fas-user-ninja")]
        SolidUserNinja = 0xf504,
        ///<summary>Solid User Nurse</summary>
        ///<see href="https://fontawesome.com/icons/user-nurse?style=solid"/>
        [Description("Solid User Nurse"), IconID("fas-user-nurse")]
        SolidUserNurse = 0xf82f,
        ///<summary>Solid User Plus</summary>
        ///<see href="https://fontawesome.com/icons/user-plus?style=solid"/>
        [Description("Solid User Plus"), IconID("fas-user-plus")]
        SolidUserPlus = 0xf234,
        ///<summary>Solid User Secret</summary>
        ///<see href="https://fontawesome.com/icons/user-secret?style=solid"/>
        [Description("Solid User Secret"), IconID("fas-user-secret")]
        SolidUserSecret = 0xf21b,
        ///<summary>Solid User Shield</summary>
        ///<see href="https://fontawesome.com/icons/user-shield?style=solid"/>
        [Description("Solid User Shield"), IconID("fas-user-shield")]
        SolidUserShield = 0xf505,
        ///<summary>Solid User Slash</summary>
        ///<see href="https://fontawesome.com/icons/user-slash?style=solid"/>
        [Description("Solid User Slash"), IconID("fas-user-slash")]
        SolidUserSlash = 0xf506,
        ///<summary>Solid User Tag</summary>
        ///<see href="https://fontawesome.com/icons/user-tag?style=solid"/>
        [Description("Solid User Tag"), IconID("fas-user-tag")]
        SolidUserTag = 0xf507,
        ///<summary>Solid User Tie</summary>
        ///<see href="https://fontawesome.com/icons/user-tie?style=solid"/>
        [Description("Solid User Tie"), IconID("fas-user-tie")]
        SolidUserTie = 0xf508,
        ///<summary>Solid User Times</summary>
        ///<see href="https://fontawesome.com/icons/user-times?style=solid"/>
        [Description("Solid User Times"), IconID("fas-user-times")]
        SolidUserTimes = 0xf235,
        ///<summary>Solid Users</summary>
        ///<see href="https://fontawesome.com/icons/users?style=solid"/>
        [Description("Solid Users"), IconID("fas-users")]
        SolidUsers = 0xf0c0,
        ///<summary>Solid Users Cog</summary>
        ///<see href="https://fontawesome.com/icons/users-cog?style=solid"/>
        [Description("Solid Users Cog"), IconID("fas-users-cog")]
        SolidUsersCog = 0xf509,
        ///<summary>Solid Users Slash</summary>
        ///<see href="https://fontawesome.com/icons/users-slash?style=solid"/>
        [Description("Solid Users Slash"), IconID("fas-users-slash")]
        SolidUsersSlash = 0xe073,
        ///<summary>Solid Utensil Spoon</summary>
        ///<see href="https://fontawesome.com/icons/utensil-spoon?style=solid"/>
        [Description("Solid Utensil Spoon"), IconID("fas-utensil-spoon")]
        SolidUtensilSpoon = 0xf2e5,
        ///<summary>Solid Utensils</summary>
        ///<see href="https://fontawesome.com/icons/utensils?style=solid"/>
        [Description("Solid Utensils"), IconID("fas-utensils")]
        SolidUtensils = 0xf2e7,
        ///<summary>Solid Vector Square</summary>
        ///<see href="https://fontawesome.com/icons/vector-square?style=solid"/>
        [Description("Solid Vector Square"), IconID("fas-vector-square")]
        SolidVectorSquare = 0xf5cb,
        ///<summary>Solid Venus</summary>
        ///<see href="https://fontawesome.com/icons/venus?style=solid"/>
        [Description("Solid Venus"), IconID("fas-venus")]
        SolidVenus = 0xf221,
        ///<summary>Solid Venus Double</summary>
        ///<see href="https://fontawesome.com/icons/venus-double?style=solid"/>
        [Description("Solid Venus Double"), IconID("fas-venus-double")]
        SolidVenusDouble = 0xf226,
        ///<summary>Solid Venus Mars</summary>
        ///<see href="https://fontawesome.com/icons/venus-mars?style=solid"/>
        [Description("Solid Venus Mars"), IconID("fas-venus-mars")]
        SolidVenusMars = 0xf228,
        ///<summary>Solid Vest</summary>
        ///<see href="https://fontawesome.com/icons/vest?style=solid"/>
        [Description("Solid Vest"), IconID("fas-vest")]
        SolidVest = 0xe085,
        ///<summary>Solid Vest Patches</summary>
        ///<see href="https://fontawesome.com/icons/vest-patches?style=solid"/>
        [Description("Solid Vest Patches"), IconID("fas-vest-patches")]
        SolidVestPatches = 0xe086,
        ///<summary>Solid Vial</summary>
        ///<see href="https://fontawesome.com/icons/vial?style=solid"/>
        [Description("Solid Vial"), IconID("fas-vial")]
        SolidVial = 0xf492,
        ///<summary>Solid Vials</summary>
        ///<see href="https://fontawesome.com/icons/vials?style=solid"/>
        [Description("Solid Vials"), IconID("fas-vials")]
        SolidVials = 0xf493,
        ///<summary>Solid Video</summary>
        ///<see href="https://fontawesome.com/icons/video?style=solid"/>
        [Description("Solid Video"), IconID("fas-video")]
        SolidVideo = 0xf03d,
        ///<summary>Solid Video Slash</summary>
        ///<see href="https://fontawesome.com/icons/video-slash?style=solid"/>
        [Description("Solid Video Slash"), IconID("fas-video-slash")]
        SolidVideoSlash = 0xf4e2,
        ///<summary>Solid Vihara</summary>
        ///<see href="https://fontawesome.com/icons/vihara?style=solid"/>
        [Description("Solid Vihara"), IconID("fas-vihara")]
        SolidVihara = 0xf6a7,
        ///<summary>Solid Virus</summary>
        ///<see href="https://fontawesome.com/icons/virus?style=solid"/>
        [Description("Solid Virus"), IconID("fas-virus")]
        SolidVirus = 0xe074,
        ///<summary>Solid Virus Slash</summary>
        ///<see href="https://fontawesome.com/icons/virus-slash?style=solid"/>
        [Description("Solid Virus Slash"), IconID("fas-virus-slash")]
        SolidVirusSlash = 0xe075,
        ///<summary>Solid Viruses</summary>
        ///<see href="https://fontawesome.com/icons/viruses?style=solid"/>
        [Description("Solid Viruses"), IconID("fas-viruses")]
        SolidViruses = 0xe076,
        ///<summary>Solid Voicemail</summary>
        ///<see href="https://fontawesome.com/icons/voicemail?style=solid"/>
        [Description("Solid Voicemail"), IconID("fas-voicemail")]
        SolidVoicemail = 0xf897,
        ///<summary>Solid Volleyball Ball</summary>
        ///<see href="https://fontawesome.com/icons/volleyball-ball?style=solid"/>
        [Description("Solid Volleyball Ball"), IconID("fas-volleyball-ball")]
        SolidVolleyballBall = 0xf45f,
        ///<summary>Solid Volume Down</summary>
        ///<see href="https://fontawesome.com/icons/volume-down?style=solid"/>
        [Description("Solid Volume Down"), IconID("fas-volume-down")]
        SolidVolumeDown = 0xf027,
        ///<summary>Solid Volume Mute</summary>
        ///<see href="https://fontawesome.com/icons/volume-mute?style=solid"/>
        [Description("Solid Volume Mute"), IconID("fas-volume-mute")]
        SolidVolumeMute = 0xf6a9,
        ///<summary>Solid Volume Off</summary>
        ///<see href="https://fontawesome.com/icons/volume-off?style=solid"/>
        [Description("Solid Volume Off"), IconID("fas-volume-off")]
        SolidVolumeOff = 0xf026,
        ///<summary>Solid Volume Up</summary>
        ///<see href="https://fontawesome.com/icons/volume-up?style=solid"/>
        [Description("Solid Volume Up"), IconID("fas-volume-up")]
        SolidVolumeUp = 0xf028,
        ///<summary>Solid Vote Yea</summary>
        ///<see href="https://fontawesome.com/icons/vote-yea?style=solid"/>
        [Description("Solid Vote Yea"), IconID("fas-vote-yea")]
        SolidVoteYea = 0xf772,
        ///<summary>Solid Vr Cardboard</summary>
        ///<see href="https://fontawesome.com/icons/vr-cardboard?style=solid"/>
        [Description("Solid Vr Cardboard"), IconID("fas-vr-cardboard")]
        SolidVrCardboard = 0xf729,
        ///<summary>Solid Walking</summary>
        ///<see href="https://fontawesome.com/icons/walking?style=solid"/>
        [Description("Solid Walking"), IconID("fas-walking")]
        SolidWalking = 0xf554,
        ///<summary>Solid Wallet</summary>
        ///<see href="https://fontawesome.com/icons/wallet?style=solid"/>
        [Description("Solid Wallet"), IconID("fas-wallet")]
        SolidWallet = 0xf555,
        ///<summary>Solid Warehouse</summary>
        ///<see href="https://fontawesome.com/icons/warehouse?style=solid"/>
        [Description("Solid Warehouse"), IconID("fas-warehouse")]
        SolidWarehouse = 0xf494,
        ///<summary>Solid Water</summary>
        ///<see href="https://fontawesome.com/icons/water?style=solid"/>
        [Description("Solid Water"), IconID("fas-water")]
        SolidWater = 0xf773,
        ///<summary>Solid Wave Square</summary>
        ///<see href="https://fontawesome.com/icons/wave-square?style=solid"/>
        [Description("Solid Wave Square"), IconID("fas-wave-square")]
        SolidWaveSquare = 0xf83e,
        ///<summary>Solid Weight</summary>
        ///<see href="https://fontawesome.com/icons/weight?style=solid"/>
        [Description("Solid Weight"), IconID("fas-weight")]
        SolidWeight = 0xf496,
        ///<summary>Solid Weight Hanging</summary>
        ///<see href="https://fontawesome.com/icons/weight-hanging?style=solid"/>
        [Description("Solid Weight Hanging"), IconID("fas-weight-hanging")]
        SolidWeightHanging = 0xf5cd,
        ///<summary>Solid Wheelchair</summary>
        ///<see href="https://fontawesome.com/icons/wheelchair?style=solid"/>
        [Description("Solid Wheelchair"), IconID("fas-wheelchair")]
        SolidWheelchair = 0xf193,
        ///<summary>Solid Wifi</summary>
        ///<see href="https://fontawesome.com/icons/wifi?style=solid"/>
        [Description("Solid Wifi"), IconID("fas-wifi")]
        SolidWifi = 0xf1eb,
        ///<summary>Solid Wind</summary>
        ///<see href="https://fontawesome.com/icons/wind?style=solid"/>
        [Description("Solid Wind"), IconID("fas-wind")]
        SolidWind = 0xf72e,
        ///<summary>Solid Window Close</summary>
        ///<see href="https://fontawesome.com/icons/window-close?style=solid"/>
        [Description("Solid Window Close"), IconID("fas-window-close")]
        SolidWindowClose = 0xf410,
        ///<summary>Solid Window Maximize</summary>
        ///<see href="https://fontawesome.com/icons/window-maximize?style=solid"/>
        [Description("Solid Window Maximize"), IconID("fas-window-maximize")]
        SolidWindowMaximize = 0xf2d0,
        ///<summary>Solid Window Minimize</summary>
        ///<see href="https://fontawesome.com/icons/window-minimize?style=solid"/>
        [Description("Solid Window Minimize"), IconID("fas-window-minimize")]
        SolidWindowMinimize = 0xf2d1,
        ///<summary>Solid Window Restore</summary>
        ///<see href="https://fontawesome.com/icons/window-restore?style=solid"/>
        [Description("Solid Window Restore"), IconID("fas-window-restore")]
        SolidWindowRestore = 0xf2d2,
        ///<summary>Solid Wine Bottle</summary>
        ///<see href="https://fontawesome.com/icons/wine-bottle?style=solid"/>
        [Description("Solid Wine Bottle"), IconID("fas-wine-bottle")]
        SolidWineBottle = 0xf72f,
        ///<summary>Solid Wine Glass</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass?style=solid"/>
        [Description("Solid Wine Glass"), IconID("fas-wine-glass")]
        SolidWineGlass = 0xf4e3,
        ///<summary>Solid Wine Glass Alt</summary>
        ///<see href="https://fontawesome.com/icons/wine-glass-alt?style=solid"/>
        [Description("Solid Wine Glass Alt"), IconID("fas-wine-glass-alt")]
        SolidWineGlassAlt = 0xf5ce,
        ///<summary>Solid Won Sign</summary>
        ///<see href="https://fontawesome.com/icons/won-sign?style=solid"/>
        [Description("Solid Won Sign"), IconID("fas-won-sign")]
        SolidWonSign = 0xf159,
        ///<summary>Solid Wrench</summary>
        ///<see href="https://fontawesome.com/icons/wrench?style=solid"/>
        [Description("Solid Wrench"), IconID("fas-wrench")]
        SolidWrench = 0xf0ad,
        ///<summary>Solid X Ray</summary>
        ///<see href="https://fontawesome.com/icons/x-ray?style=solid"/>
        [Description("Solid X Ray"), IconID("fas-x-ray")]
        SolidXRay = 0xf497,
        ///<summary>Solid Yen Sign</summary>
        ///<see href="https://fontawesome.com/icons/yen-sign?style=solid"/>
        [Description("Solid Yen Sign"), IconID("fas-yen-sign")]
        SolidYenSign = 0xf157,
        ///<summary>Solid Yin Yang</summary>
        ///<see href="https://fontawesome.com/icons/yin-yang?style=solid"/>
        [Description("Solid Yin Yang"), IconID("fas-yin-yang")]
        SolidYinYang = 0xf6ad
    }
}
