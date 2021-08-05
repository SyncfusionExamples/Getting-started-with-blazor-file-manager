

namespace Syncfusion.EJ2.FileManager.Base
{
    public interface FirebaseRealtimeFileProviderBase : FileProviderBase
    {
        void RegisterFirebaseRealtimeDB(string apiUrl, string rootNode, string serviceAccountKeyPath);
    }

}
