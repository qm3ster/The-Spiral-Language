module SpiralExample.Main
let cuda_kernels = """

extern "C" {
    
}
"""

type EnvStack0 =
    struct
    val mem_0: int64
    val mem_1: int64
    new(arg_mem_0, arg_mem_1) = {mem_0 = arg_mem_0; mem_1 = arg_mem_1}
    end
let (var_0: int64) = 0L
let (var_1: int64) = 0L
let (var_2: EnvStack0) = EnvStack0((var_0: int64), (var_1: int64))
let (var_3: (EnvStack0 [])) = Array.zeroCreate<EnvStack0> (System.Convert.ToInt32(3L))
let (var_4: int64) = var_2.mem_0
let (var_5: int64) = var_2.mem_1
let (var_6: int64) = 10L
let (var_7: int64) = 20L
let (var_8: EnvStack0) = EnvStack0((var_6: int64), (var_7: int64))
var_3.[int32 0L] <- var_8
let (var_9: int64) = 20L
let (var_10: int64) = 10L
let (var_11: EnvStack0) = EnvStack0((var_9: int64), (var_10: int64))
var_3.[int32 1L] <- var_11

