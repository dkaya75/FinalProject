namespace Core.Entities.Concrete
{//tablodaki güvenlik için oluşturduğum tablolar
    class UserOperationClaim:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
