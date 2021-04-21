using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class JobCard:commonModels
    {
        public long jobCardId { get; set; }
        public long jobCardNo { get; set; }
        public long customerId { get; set; }
        public long tagNo { get; set; }
        public int technicalCode { get; set; }
        public double totalRupee { get; set; }
        public double advnceAmount { get; set; }
        public double remainingAmt { get; set; }
        public DateTime jobReceiveDate { get; set; }
        public DateTime jobReceiveTime { get; set; }
        public DateTime jobDeliveryDate { get; set; }
        public DateTime jobDeliveryTime { get; set; }
    }
    public class ShrinathEngg : commonModels
    {
        public int shrinathId { get; set; }
        public int orjId { get; set; }
        public long jobCardId { get; set; }
        public int moterId { get; set; }
        public string make { get; set; }
        public string HP { get; set; }
        public string RPM { get; set; }
        public Boolean wholeMotor { get; set; }
        public Boolean onlyMotor { get; set; }
        public Boolean onlyPump { get; set; }
        public Boolean Starter { get; set; }
        public string infoJobRepairingByCustomer { get; set; }
        public string labourChargeTentiveAmount { get; set; }
        public string extraWork { get; set; }
        public string jobReceiverName { get; set; }
        public string totalLabourExpence { get; set; }
        public string revaydingAmt { get; set; }
        public string kholFeeting { get; set; }
        public string materialUsed { get; set; }
    }
    public class saiEnggWorks : commonModels
    {
        public int saiEnggID { get; set; }
        public int orjId { get; set; }
        public int motorID { get; set; }
        public int jobCardId { get; set; }
        public Boolean wholeMotor { get; set; }
        public Boolean onlyMotor { get; set; }
        public Boolean onlyPump { get; set; }
        public Boolean roter { get; set; }
        public Boolean upperHoujing { get; set; }
        public Boolean lowerHoujing { get; set; }
        public Boolean Apiler { get; set; }
        public string infoJobRepairingByRevayders { get; set; }
        public string workNeeded { get; set; }
        public Boolean setGrinding { get; set; }
        public Boolean oilSealGala { get; set; }
        public Boolean kalpingChaviGala { get; set; }
        public Boolean thusWTChaviGala { get; set; }
        public Boolean pumpKalpingGreding { get; set; }
        public Boolean kalpingBushBoar { get; set; }
        public Boolean centerBushBoar { get; set; }
        public Boolean topBushBoar { get; set; }
        public Boolean castingW { get; set; }
        public Boolean drilingTapping { get; set; }
        public Boolean threding { get; set; }
        public Boolean apilerCutting { get; set; }
        public Boolean shaftSlivAlteration { get; set; }
        public Boolean removeShaftBend { get; set; }
        public Boolean pres { get; set; }
        public Boolean makeFiberPlate { get; set; }
        public Boolean bushLearning { get; set; }
        public Boolean monoTrading { get; set; }
        public Boolean monoBushSizeWT { get; set; }
        public Boolean monoShaftLerning { get; set; }
        public Boolean monoOilSealSizeWT { get; set; }
        public Boolean monoApilerSizeWT { get; set; }
        public Boolean monoApilerBoarBush { get; set; }
        public Boolean monoShaftBend { get; set; }
        public Boolean monoDilingDiping { get; set; }
        public Boolean monoShaftJoint { get; set; }
        public Boolean monoOilSealBodyBush { get; set; }
        public Boolean monoCastingWT { get; set; }
        public Boolean monoPress { get; set; }
        public Boolean BooleanmonoCheckRoter { get; set; }
        public Boolean monoNoOneBearingSize { get; set; }
        public Boolean noOnebaringSize { get; set; }
        public Boolean monoNoTwoBearingSize { get; set; }
        public Boolean noTwoBearingSize { get; set; }
        public Boolean monoBodySleave { get; set; }
        public Boolean bodySleave { get; set; }
        public Boolean monoCoverSleave { get; set; }
        public Boolean coverSleave { get; set; }
        public Boolean CheckRoter { get; set; }

    }
    public class vimalTraders : commonModels
    {
        public int VimalTradersID { get; set; }
        public int orjId { get; set; }
        public int jobCardId { get; set; }
        public int BillNo { get; set; }
        public DateTime invoiceDate { get; set; }
        public float TotalAmount { get; set; }
        public string RevaydingTechnishiyan { get; set; }
        public string MotorMake { get; set; }
        public int MotorID { get; set; }
        public string pitch { get; set; }
        public string tern { get; set; }
        public string groupWeight { get; set; }
        public string WaydingLayer { get; set; }
        public string TotalWeight { get; set; }
        public string Gej { get; set; }
        public string StaterLength { get; set; }
        public string megerTest { get; set; }
        public string emptyApiler { get; set; }
        public string stertingFarm { get; set; }
        public string apilerOnLoad { get; set; }

    }
    public class SarveshMotor : commonModels
    {
        long SarveshMotorId { get; set; }
        int orjId { get; set; }
        long jobCardId { get; set; }
        int motorId { get; set; }
        int quantity { get; set; }
        float rate { get; set; }
    }

    public class bindJobCard
    {
        public long jobCardId { get; set; }
        public long jobCardNo { get; set; }
    }
}
