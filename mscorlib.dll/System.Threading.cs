#region 程序集 mscorlib.dll, v4.0.30319
// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Profile\Client\mscorlib.dll
#endregion

/// #region #endregion 作用：折叠代码，代码会执行
/// #region后面所接字符为折叠后显示的字符

using System;
using System.Globalization;
using System.Runtime;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Principal;

namespace System.Threading
{
    // 摘要:
    //     创建并控制线程，设置其优先级并获取其状态。
    [ClassInterface(ClassInterfaceType.None)]
    /// 指示在完全生成某个接口后为要向 COM 公开的类生成的类接口类型。
    
    [ComDefaultInterface(typeof(_Thread))]
    /// 指定要向 COM 公开的默认接口
    /// typeof: 判断对象、类型
    
    [ComVisible(true)]
    /// 指示应用该属性的对象是否对COM可见
    
    public sealed class Thread : CriticalFinalizerObject, _Thread
    {
        /// sealed 密封关键字，由它修饰的类或方法将不能被继承或是重写
        
        // 摘要:
        //     初始化 System.Threading.Thread 类的新实例，指定允许对象在线程启动时传递给线程的委托。
        //
        // 参数:
        //   start:
        //     System.Threading.ParameterizedThreadStart 委托，它表示此线程开始执行时要调用的方法。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     start 为 null。
        [SecuritySafeCritical]
        /// 将类型或成员标识为透明代码可以安全访问的安全关键类型或成员。
        public Thread(ParameterizedThreadStart start);
        //
        // 摘要:
        //     初始化 System.Threading.Thread 类的新实例。
        //
        // 参数:
        //   start:
        //     System.Threading.ThreadStart 委托，它表示此线程开始执行时要调用的方法。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     start 参数为 null。
        [SecuritySafeCritical]
        public Thread(ThreadStart start);
        //
        // 摘要:
        //     初始化 System.Threading.Thread 类的新实例，指定允许对象在线程启动时传递给线程的委托，并指定线程的最大堆栈大小。
        //
        // 参数:
        //   start:
        //     System.Threading.ParameterizedThreadStart 委托，它表示此线程开始执行时要调用的方法。
        //
        //   maxStackSize:
        //     线程要使用的最大堆栈大小；如果为 0 则使用可执行文件的文件头中指定的默认最大堆栈大小。Important对于部分受信任的代码，如果 maxStackSize
        //     大于默认堆栈大小，则将其忽略。未引发异常。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     start 为 null。
        //
        //   System.ArgumentOutOfRangeException:
        //     maxStackSize 小于零。
        [SecuritySafeCritical]
        public Thread(ParameterizedThreadStart start, int maxStackSize);
        //
        // 摘要:
        //     初始化 System.Threading.Thread 类的新实例，指定线程的最大堆栈大小。
        //
        // 参数:
        //   start:
        //     System.Threading.ThreadStart 委托，它表示此线程开始执行时要调用的方法。
        //
        //   maxStackSize:
        //     线程要使用的最大堆栈大小；如果为 0 则使用可执行文件的文件头中指定的默认最大堆栈大小。Important对于部分受信任的代码，如果 maxStackSize
        //     大于默认堆栈大小，则将其忽略。未引发异常。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     start 为 null。
        //
        //   System.ArgumentOutOfRangeException:
        //     maxStackSize 小于零。
        [SecuritySafeCritical]
        public Thread(ThreadStart start, int maxStackSize);

        // 摘要:
        //     获取或设置此线程的单元状态。
        //
        // 返回结果:
        //     System.Threading.ApartmentState 值之一。初始值为 Unknown。
        //
        // 异常:
        //   System.ArgumentException:
        //     尝试将此属性设置为无效单元状态（即单线程单元 (STA) 或多线程单元 (MTA) 以外的状态）。
        [Obsolete("The ApartmentState property has been deprecated.  Use GetApartmentState, SetApartmentState or TrySetApartmentState instead.", false)]
        /// 标记该方法是一个被荒弃的方法或者属性
        public ApartmentState ApartmentState { get; set; }
        //
        // 摘要:
        //     获取线程正在其中执行的当前上下文。
        //
        // 返回结果:
        //     System.Runtime.Remoting.Contexts.Context，它表示当前线程上下文。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方没有所要求的权限。
        public static Context CurrentContext { get; }
        /// static关键字*****
        //
        // 摘要:
        //     获取或设置当前线程的区域性。
        //
        // 返回结果:
        //     一个 System.Globalization.CultureInfo，它表示当前线程的区域性。
        //
        // 异常:
        //   System.NotSupportedException:
        //     此属性设置为非特定区域性。非特定区域性不能用于设置格式和分析，因此不能设置为线程的当前区域性。
        //
        //   System.ArgumentNullException:
        //     该属性设置为 null。
        public CultureInfo CurrentCulture { get; set; }
        //
        // 摘要:
        //     获取或设置线程的当前负责人（对基于角色的安全性而言）。
        //
        // 返回结果:
        //     System.Security.Principal.IPrincipal 值，它表示安全上下文。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方不具有设置该主体所需的权限。
        public static IPrincipal CurrentPrincipal { get; set; }
        //
        // 摘要:
        //     获取当前正在运行的线程。
        //
        // 返回结果:
        //     System.Threading.Thread，它是当前正在运行的线程的表示形式。
        public static Thread CurrentThread { get; }
        //
        // 摘要:
        //     获取或设置资源管理器使用的当前区域性以便在运行时查找区域性特定的资源。
        //
        // 返回结果:
        //     System.Globalization.CultureInfo，它表示当前区域性。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     该属性设置为 null。
        //
        //   System.ArgumentException:
        //     此属性被设置为不能用于定位资源文件的区域性名称。资源文件名只能包含字母、数字、连字符或下划线。
        public CultureInfo CurrentUICulture { get; set; }
        //
        // 摘要:
        //     获取一个 System.Threading.ExecutionContext 对象，该对象包含有关当前线程的各种上下文的信息。
        //
        // 返回结果:
        //     System.Threading.ExecutionContext 对象，合并了当前线程的上下文信息。
        public ExecutionContext ExecutionContext { get; }
        //
        // 摘要:
        //     获取一个值，该值指示当前线程的执行状态。
        //
        // 返回结果:
        //     如果此线程已启动并且尚未正常终止或中止，则为 true；否则为 false。
        public bool IsAlive { get; }
        //
        // 摘要:
        //     获取或设置一个值，该值指示某个线程是否为后台线程。
        //
        // 返回结果:
        //     如果此线程是后台线程或即将成为后台线程，则为 true；否则为 false。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     线程已死。
        public bool IsBackground { get; set; }
        //
        // 摘要:
        //     获取一个值，该值指示线程是否属于托管线程池。
        //
        // 返回结果:
        //     如果此线程属于托管线程池，则为 true；否则为 false。
        public bool IsThreadPoolThread { get; }
        //
        // 摘要:
        //     获取当前托管线程的唯一标识符。
        //
        // 返回结果:
        //     一个整数，表示此托管线程的唯一标识符。
        public int ManagedThreadId { get; }
        //
        // 摘要:
        //     获取或设置线程的名称。
        //
        // 返回结果:
        //     包含线程名称的字符串，或者如果未设置名称，则为 null。
        //
        // 异常:
        //   System.InvalidOperationException:
        //     请求设置操作，但已设置了 Name 属性。
        public string Name { get; set; }
        //
        // 摘要:
        //     获取或设置一个值，该值指示线程的调度优先级。
        //
        // 返回结果:
        //     System.Threading.ThreadPriority 值之一。默认值为 Normal。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     线程已到达最终状态，例如 System.Threading.ThreadState.Aborted。
        //
        //   System.ArgumentException:
        //     为设置操作指定的值不是有效的 ThreadPriority 值。
        public ThreadPriority Priority { get; set; }
        //
        // 摘要:
        //     获取一个值，该值包含当前线程的状态。
        //
        // 返回结果:
        //     System.Threading.ThreadState 值之一，它指示当前线程的状态。初始值为 Unstarted。
        public ThreadState ThreadState { get; }

        // 摘要:
        //     在调用此方法的线程上引发 System.Threading.ThreadAbortException，以开始终止此线程的过程。调用此方法通常会终止线程。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方没有所要求的权限。
        //
        //   System.Threading.ThreadStateException:
        //     中止的线程当前被挂起。
        [SecuritySafeCritical]
        public void Abort();
        //
        // 摘要:
        //     在调用此方法的线程上引发 System.Threading.ThreadAbortException，以开始终止此线程并提供有关线程终止的异常信息的过程。调用此方法通常会终止线程。
        //
        // 参数:
        //   stateInfo:
        //     一个对象，它包含应用程序特定的信息（如状态），该信息可供正被中止的线程使用。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方没有所要求的权限。
        //
        //   System.Threading.ThreadStateException:
        //     中止的线程当前被挂起。
        [SecuritySafeCritical]
        public void Abort(object stateInfo);
        //
        // 摘要:
        //     在所有的线程上分配未命名的数据槽。为了获得更好的性能，请改用以 System.ThreadStaticAttribute 特性标记的字段。
        //
        // 返回结果:
        //     System.LocalDataStoreSlot。
        public static LocalDataStoreSlot AllocateDataSlot();
        //
        // 摘要:
        //     在所有线程上分配已命名的数据槽。为了获得更好的性能，请改用以 System.ThreadStaticAttribute 特性标记的字段。
        //
        // 参数:
        //   name:
        //     要分配的数据槽的名称。
        //
        // 返回结果:
        //     System.LocalDataStoreSlot。
        //
        // 异常:
        //   System.ArgumentException:
        //     已存在以指定的名称命名的数据槽。
        public static LocalDataStoreSlot AllocateNamedDataSlot(string name);
        //
        // 摘要:
        //     通知宿主执行将要进入一个代码区域，在该代码区域内线程中止或未经处理的异常的影响可能会危害应用程序域中的其他任务。
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecuritySafeCritical]
        public static void BeginCriticalRegion();
        //
        // 摘要:
        //     通知宿主托管代码将要执行依赖于当前物理操作系统线程的标识的指令。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方没有所要求的权限。
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCritical]
        public static void BeginThreadAffinity();
        //
        // 摘要:
        //     对于当前线程关闭运行时可调用包装 (RCW) 的自动清理。
        [SecurityCritical]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public void DisableComObjectEagerCleanup();
        //
        // 摘要:
        //     通知宿主执行将要进入一个代码区域，在该代码区域内线程中止或未经处理的异常仅影响当前任务。
        [SecuritySafeCritical]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public static void EndCriticalRegion();
        //
        // 摘要:
        //     通知宿主托管代码已执行完依赖于当前物理操作系统线程的标识的指令。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方没有所要求的权限。
        [SecurityCritical]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public static void EndThreadAffinity();
        //
        // 摘要:
        //     为进程中的所有线程消除名称与槽之间的关联。为了获得更好的性能，请改用以 System.ThreadStaticAttribute 特性标记的字段。
        //
        // 参数:
        //   name:
        //     要释放的数据槽的名称。
        public static void FreeNamedDataSlot(string name);
        //
        // 摘要:
        //     返回一个 System.Threading.ApartmentState 值，该值指示单元状态。
        //
        // 返回结果:
        //     System.Threading.ApartmentState 值之一，它指示托管线程的单元状态。默认值为 System.Threading.ApartmentState.Unknown。
        [SecuritySafeCritical]
        public ApartmentState GetApartmentState();
        //
        // 摘要:
        //     返回一个 System.Threading.CompressedStack 对象，该对象可用于捕获当前线程的堆栈。
        //
        // 返回结果:
        //     无。
        //
        // 异常:
        //   System.InvalidOperationException:
        //     在所有情况下。
        [SecurityCritical]
        [Obsolete("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        public CompressedStack GetCompressedStack();
        //
        // 摘要:
        //     在当前线程的当前域中从当前线程上指定的槽中检索值。为了获得更好的性能，请改用以 System.ThreadStaticAttribute 特性标记的字段。
        //
        // 参数:
        //   slot:
        //     要从其中获取值的 System.LocalDataStoreSlot。
        //
        // 返回结果:
        //     检索到的值。
        public static object GetData(LocalDataStoreSlot slot);
        //
        // 摘要:
        //     返回当前线程正在其中运行的当前域。
        //
        // 返回结果:
        //     System.AppDomain，它表示正在运行的线程的当前应用程序域。
        [SecuritySafeCritical]
        public static AppDomain GetDomain();
        //
        // 摘要:
        //     返回唯一的应用程序域标识符。
        //
        // 返回结果:
        //     唯一标识应用程序域的 32 位有符号整数。
        [SecuritySafeCritical]
        public static int GetDomainID();
        //
        // 摘要:
        //     返回当前线程的哈希代码。
        //
        // 返回结果:
        //     整数哈希代码值。
        [ComVisible(false)]
        public override int GetHashCode();
        //
        // 摘要:
        //     查找已命名的数据槽。为了获得更好的性能，请改用以 System.ThreadStaticAttribute 特性标记的字段。
        //
        // 参数:
        //   name:
        //     本地数据槽的名称。
        //
        // 返回结果:
        //     为此线程分配的 System.LocalDataStoreSlot。
        public static LocalDataStoreSlot GetNamedDataSlot(string name);
        //
        // 摘要:
        //     中断处于 WaitSleepJoin 线程状态的线程。
        //
        // 异常:
        //   System.Security.SecurityException:
        //     调用方没有适当的 System.Security.Permissions.SecurityPermission。
        [SecuritySafeCritical]
        public void Interrupt();
        //
        // 摘要:
        //     在继续执行标准的 COM 和 SendMessage 消息泵处理期间，阻塞调用线程，直到某个线程终止为止。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     调用方尝试联接一个处于 System.Threading.ThreadState.Unstarted 状态的线程。
        //
        //   System.Threading.ThreadInterruptedException:
        //     此线程在等待时被中断。
        [SecuritySafeCritical]
        public void Join();
        //
        // 摘要:
        //     在继续执行标准的 COM 和 SendMessage 消息泵处理期间，阻塞调用线程，直到某个线程终止或经过了指定时间为止。
        //
        // 参数:
        //   millisecondsTimeout:
        //     等待线程终止的毫秒数。
        //
        // 返回结果:
        //     如果线程已终止，则为 true；如果线程在经过了 millisecondsTimeout 参数指定的时间量后未终止，则为 false。
        //
        // 异常:
        //   System.ArgumentOutOfRangeException:
        //     millisecondsTimeout 的值为负且不等于 System.Threading.Timeout.Infinite（以毫秒为单位）。
        //
        //   System.Threading.ThreadStateException:
        //     该线程尚未启动。
        [SecuritySafeCritical]
        public bool Join(int millisecondsTimeout);
        //
        // 摘要:
        //     在继续执行标准的 COM 和 SendMessage 消息泵处理期间，阻塞调用线程，直到某个线程终止或经过了指定时间为止。
        //
        // 参数:
        //   timeout:
        //     设置为等待线程终止的时间量的 System.TimeSpan。
        //
        // 返回结果:
        //     如果线程已终止，则为 true；如果线程在经过了 timeout 参数指定的时间量后未终止，则为 false。
        //
        // 异常:
        //   System.ArgumentOutOfRangeException:
        //     timeout 的值为负，而且不等于 System.Threading.Timeout.Infinite（以毫秒为单位），或者大于 System.Int32.MaxValue
        //     毫秒。
        //
        //   System.Threading.ThreadStateException:
        //     调用方尝试联接一个处于 System.Threading.ThreadState.Unstarted 状态的线程。
        public bool Join(TimeSpan timeout);
        //
        // 摘要:
        //     按如下方式同步内存访问：执行当前线程的处理器在对指令重新排序时，不能采用先执行 System.Threading.Thread.MemoryBarrier()
        //     调用之后的内存访问，再执行 System.Threading.Thread.MemoryBarrier() 调用之前的内存访问的方式。
        [SecuritySafeCritical]
        public static void MemoryBarrier();
        //
        // 摘要:
        //     取消为当前线程请求的 System.Threading.Thread.Abort(System.Object)。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     未对当前线程调用 Abort。
        //
        //   System.Security.SecurityException:
        //     调用方不拥有当前线程所需的安全权限。
        [SecuritySafeCritical]
        public static void ResetAbort();
        //
        // 摘要:
        //     继续已挂起的线程。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     线程尚未启动、已死或不处于挂起状态。
        //
        //   System.Security.SecurityException:
        //     调用方没有适当的 System.Security.Permissions.SecurityPermission。
        [SecuritySafeCritical]
        [Obsolete("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public void Resume();
        //
        // 摘要:
        //     在线程启动前设置其单元状态。
        //
        // 参数:
        //   state:
        //     新的单元状态。
        //
        // 异常:
        //   System.ArgumentException:
        //     state 不是有效的单元状态。
        //
        //   System.Threading.ThreadStateException:
        //     线程已启动。
        //
        //   System.InvalidOperationException:
        //     单元状态已经初始化。
        [SecuritySafeCritical]
        public void SetApartmentState(ApartmentState state);
        //
        // 摘要:
        //     对当前线程应用捕获的 System.Threading.CompressedStack。
        //
        // 参数:
        //   stack:
        //     要对当前线程应用的 System.Threading.CompressedStack 对象。
        //
        // 异常:
        //   System.InvalidOperationException:
        //     在所有情况下。
        [Obsolete("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
        [SecurityCritical]
        public void SetCompressedStack(CompressedStack stack);
        //
        // 摘要:
        //     在当前正在运行的线程上为此线程的当前域在指定槽中设置数据。为了获得更好的性能，请改用以 System.ThreadStaticAttribute
        //     特性标记的字段。
        //
        // 参数:
        //   slot:
        //     在其中设置值的 System.LocalDataStoreSlot。
        //
        //   data:
        //     要设置的值。
        public static void SetData(LocalDataStoreSlot slot, object data);
        //
        // 摘要:
        //     将当前线程挂起指定的时间。
        //
        // 参数:
        //   millisecondsTimeout:
        //     线程被阻塞的毫秒数。指定零 (0) 以指示应挂起此线程以使其他等待线程能够执行。指定 System.Threading.Timeout.Infinite
        //     以无限期阻止线程。
        //
        // 异常:
        //   System.ArgumentOutOfRangeException:
        //     超时值为负且不等于 System.Threading.Timeout.Infinite。
        [SecuritySafeCritical]
        public static void Sleep(int millisecondsTimeout);
        //
        // 摘要:
        //     将当前线程阻塞指定的时间。
        //
        // 参数:
        //   timeout:
        //     设置为线程被阻塞的时间量的 System.TimeSpan。指定零以指示应挂起此线程以使其他等待线程能够执行。指定 System.Threading.Timeout.Infinite
        //     以无限期阻止线程。
        //
        // 异常:
        //   System.ArgumentOutOfRangeException:
        //     timeout 的值为负，而且不等于 System.Threading.Timeout.Infinite（以毫秒为单位），或者大于 System.Int32.MaxValue
        //     毫秒。
        public static void Sleep(TimeSpan timeout);
        //
        // 摘要:
        //     导致线程等待由 iterations 参数定义的时间量。
        //
        // 参数:
        //   iterations:
        //     定义线程等待时间的 32 位有符号整数。
        [SecuritySafeCritical]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public static void SpinWait(int iterations);
        //
        // 摘要:
        //     导致操作系统将当前实例的状态更改为 System.Threading.ThreadState.Running。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     线程已启动。
        //
        //   System.OutOfMemoryException:
        //     没有足够的可用内存来启动此线程。
        [SecuritySafeCritical]
        public void Start();
        //
        // 摘要:
        //     使操作系统将当前实例的状态更改为 System.Threading.ThreadState.Running，并选择提供包含线程执行的方法要使用的数据的对象。
        //
        // 参数:
        //   parameter:
        //     一个对象，包含线程执行的方法要使用的数据。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     线程已启动。
        //
        //   System.OutOfMemoryException:
        //     没有足够的可用内存来启动此线程。
        //
        //   System.InvalidOperationException:
        //     此线程是使用 System.Threading.ThreadStart 委托（而不是 System.Threading.ParameterizedThreadStart
        //     委托）创建的。
        [SecuritySafeCritical]
        public void Start(object parameter);
        //
        // 摘要:
        //     挂起线程，或者如果线程已挂起，则不起作用。
        //
        // 异常:
        //   System.Threading.ThreadStateException:
        //     未启动线程或线程已死。
        //
        //   System.Security.SecurityException:
        //     调用方没有适当的 System.Security.Permissions.SecurityPermission。
        [SecuritySafeCritical]
        [Obsolete("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public void Suspend();
        //
        // 摘要:
        //     在线程启动前设置其单元状态。
        //
        // 参数:
        //   state:
        //     新的单元状态。
        //
        // 返回结果:
        //     如果设置单元状态，则为 true；否则为 false。
        //
        // 异常:
        //   System.ArgumentException:
        //     state 不是有效的单元状态。
        //
        //   System.Threading.ThreadStateException:
        //     线程已启动。
        [SecuritySafeCritical]
        public bool TrySetApartmentState(ApartmentState state);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static byte VolatileRead(ref byte address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static double VolatileRead(ref double address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static float VolatileRead(ref float address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static int VolatileRead(ref int address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static IntPtr VolatileRead(ref IntPtr address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static long VolatileRead(ref long address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static object VolatileRead(ref object address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        [CLSCompliant(false)]
        public static sbyte VolatileRead(ref sbyte address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        public static short VolatileRead(ref short address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        [CLSCompliant(false)]
        public static uint VolatileRead(ref uint address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        [CLSCompliant(false)]
        public static UIntPtr VolatileRead(ref UIntPtr address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        [CLSCompliant(false)]
        public static ulong VolatileRead(ref ulong address);
        //
        // 摘要:
        //     读取字段值。无论处理器的数目或处理器缓存的状态如何，该值都是由计算机的任何处理器写入的最新值。
        //
        // 参数:
        //   address:
        //     要读取的字段。
        //
        // 返回结果:
        //     由任何处理器写入字段的最新值。
        [CLSCompliant(false)]
        public static ushort VolatileRead(ref ushort address);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref byte address, byte value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref double address, double value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref float address, float value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref int address, int value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref IntPtr address, IntPtr value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref long address, long value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref object address, object value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        [CLSCompliant(false)]
        public static void VolatileWrite(ref sbyte address, sbyte value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        public static void VolatileWrite(ref short address, short value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        [CLSCompliant(false)]
        public static void VolatileWrite(ref uint address, uint value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        [CLSCompliant(false)]
        public static void VolatileWrite(ref UIntPtr address, UIntPtr value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        [CLSCompliant(false)]
        public static void VolatileWrite(ref ulong address, ulong value);
        //
        // 摘要:
        //     立即向字段写入一个值，以使该值对计算机中的所有处理器都可见。
        //
        // 参数:
        //   address:
        //     要向其中写入值的字段。
        //
        //   value:
        //     要写入的值。
        [CLSCompliant(false)]
        public static void VolatileWrite(ref ushort address, ushort value);
        //
        // 摘要:
        //     导致调用线程执行准备好在当前处理器上运行的另一个线程。由操作系统选择要执行的线程。
        //
        // 返回结果:
        //     如果操作系统转而执行另一个线程，则为 true；否则为 false。
        [SecuritySafeCritical]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        public static bool Yield();
    }
}
