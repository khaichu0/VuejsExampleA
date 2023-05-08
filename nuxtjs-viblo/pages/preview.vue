<template>
  <div class="detail">
    <div class="detail-form-block">
      <div class="detail-form-content-block">
        <div class="detail-form-content-center-block"   v-for="(phase, index) in form.phases"
          :key="index">
          <div class="detail-form-content-center-title-block">
            <div class="detail-form-content-center-title">
              {{ phase.title }}
            </div>
            <div class="detail-form-content-center-description">
              {{ phase.description }}
            </div>
          </div>
          <input
              type="text"
              width="100%"
              class="form__field"
            />
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import { v4 as uuidv4 } from "uuid";

export default {
  components: {},
  props: {
    item: Object,
    groupIndex: Number,
  },
  data() {
    return {
      form: [],
      emailItem: this.item,
      activeGroupIndex: null,
    };
  },
  mounted() {

      this.loadFromLocalStorage();

  },
  methods: {
    goBack() {
      this.$router.go(-1);
    },
    create() {
      debugger;
      this.emailItem.is_create = false;
      this.form.phases[this.groupIndex].items.push(this.emailItem);
    },
    update() {
      const a = this.form.phases.filter((row) => {
        return row;
      });
      debugger

      const b = this.item.id;
      const c= a[this.groupIndex];
      a[this.groupIndex].items.forEach((element) => {
        if (element.id == b) {
          console.log(element);
          element = this.emailItem;
        }
      });
    },
    save() {
      if (this.emailItem.is_create == true) {
        this.create();
      } else {
        this.update();
      }
      localStorage.setItem("myObject", JSON.stringify(this.form));
      this.goBack();
    },
    loadFromLocalStorage() {
      const savedObject = localStorage.getItem("myObject");
      if (savedObject) {
        this.form =JSON.parse(savedObject);
      }
    },
    findItem() {
      const a = this.form.phases.filter((row) => {
        return row;
      });
      const b = this.item.id;
      for (var i = 0; i < a.length; i++) {
        a[i].items.forEach((element) => {
          if (element.id == b) {
            console.log(element);
            this.emailItem = element;
          }
        });
      }
    },
  },
};
</script>
<style scoped>
@import "../assets/css/preview/preview.css";
</style>
