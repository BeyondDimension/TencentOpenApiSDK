# TencentOpenApiSDK
Tencent Open Platform/QQ Connect SDK for Xamarin Binding Library

English | [简体中文](./README.md)

# SDK Download
- [QQ Connect](https://wiki.connect.qq.com/sdk%e4%b8%8b%e8%bd%bd)
- [Tencent Open Platform](https://wiki.open.qq.com/wiki/mobile/SDK%E4%B8%8B%E8%BD%BD)
- [iOS_SDK_V3.5.3](https://tangram-1251316161.file.myqcloud.com/qqconnect/OpenSDK_V3.5.3/iOS_V3.5.3_Lite.zip)
- [Android_SDK_V3.5.4](https://tangram-1251316161.file.myqcloud.com/qqconnect/OpenSDK_V3.5.4/opensdk_354_lite_2021-04-27.zip)

# [iOS Binding Native Frameworks](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/platform/native-frameworks?context=xamarin/ios)
```
sharpie bind \
    -sdk iphoneos14.4 \
    ./TencentOpenAPI.framework/Headers/QQApiInterface.h \
    -scope TencentOpenAPI.framework/Headers \
    -c -F .
```

```
sharpie bind \
    -sdk iphoneos14.4 \
    ./TencentOpenAPI.framework/Headers/QQApiInterfaceObject.h \
    -scope TencentOpenAPI.framework/Headers \
    -c -F .
```

```
sharpie bind \
    -sdk iphoneos14.4 \
    ./TencentOpenAPI.framework/Headers/sdkdef.h \
    -scope TencentOpenAPI.framework/Headers \
    -c -F .
```

```
sharpie bind \
    -sdk iphoneos14.4 \
    ./TencentOpenAPI.framework/Headers/TencentOAuth.h \
    -scope TencentOpenAPI.framework/Headers \
    -c -F .
```

```
sharpie bind \
    -sdk iphoneos14.4 \
    ./TencentOpenAPI.framework/Headers/TencentOpenApiUmbrellaHeader.h \
    -scope TencentOpenAPI.framework/Headers \
    -c -F .
```

# Android Reference 
```
com.tencent.connect.auth.AuthAgent
import android.support.v4.app.Fragment;

com.tencent.connect.auth.c
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentActivity;

com.tencent.connect.common.BaseApi
import android.support.v4.app.Fragment;

com.tencent.open.a.a
import okhttp3.ConnectionSpec;
import okhttp3.FormBody;
import okhttp3.Interceptor;
import okhttp3.Interceptor.Chain;
import okhttp3.MediaType;
import okhttp3.MultipartBody;
import okhttp3.OkHttpClient;
import okhttp3.OkHttpClient.Builder;
import okhttp3.Request;
import okhttp3.RequestBody;
import okhttp3.Response;

com.tencent.open.a.b
import okhttp3.Response;
import okhttp3.ResponseBody;

com.tencent.open.utils.k
import android.support.v4.content.FileProvider;

com.tencent.tauth.Tencent
import android.support.v4.app.Fragment;
```
